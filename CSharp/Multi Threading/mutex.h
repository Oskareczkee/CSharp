#pragma once

#include <thread>
#include <iostream>
#include <vector>
#include <mutex>
#include <condition_variable>
#include <ctime>
#include <cstdlib>

//mutex, shared_mutex
//unlock, lock
// 
// Lock Guardy - "typ locka"<mutex type> nazwa (referencja do naszego mutexa)
// 
//lock_guard - po stworzeniu blokuje dane, po zniszczeniu odblokowuje je. Dane da si� tylko odblokowa� niszcz�c obiekt
//unique_lock - to samo co lock_guard, ale mo�na odblokowywa� i zablokowywa� sobie dane dowoli, po stworzeniu automatycznie blokuje dane
//shared_lock<shared_mutex> - tworzy critical section, ale wiele w�tk�w mo�e ich u�ywa�, najlepiej dawa� je do blokowania operacji typu odczyt, do zapisu itd niezalecane, mo�e powodowa� b��dy
//lock(mutex1, mutex2) - ta funkcja chroni przed deadlockiem, gdzie kilka w�tk�w mo�e czeka� na siebie nawzajem, ale ka�dy jest zablokowany, wi�c nigdy si� nie porozumiej�
//                       Wywo�ujemy j� zawsze na pocz�tku naszej funkcji, w kt�rej chcemy zaimplementowa� multi-threading
//                       Po tej funkcji w konstuktorze lock guard�w dajemy 2 argument "adopt_lock", kt�ry powoduje, �e po stworzeniu nasze mutexy nie s� od razu zablokowane, bo ju� raz je zablokowali�my funkcj� lock()
//scoped_lock - ten lock pozwala nam stworzy� lock, kt�ry automatycznie wywo�uje za nas funkcj� lock i potem nie musimy tworzy� dodatkowych guard�w w kodzie, zostan� utworzone automatycznie
//              Odblokowuje guardy, poprzez ich zniszczenie (gdy wyjdziemy poza funkcj� lub p�tl�)
//
// condition_variable
// cv.notify_one - wysy�a powiadomienie  cv.notify_all - wysy�a powiadomienia do wszystkich czekaj�cych w�tk�w, zamiast do jednego
// cv.wait(mutex, predicate) - czeka na powiadomienie --- przyk�ad predykatu (lambda) [](){return zadanie_gotowe;} w skr�cie, funkcja ta czeka a� zadanie_gotowe b�dzie ustawione na true
// Conditional variables pozwalaj� nam na porozumiewanie si� 2 funkcji w r�nych w�tkach, musz� mie� wsp�lnu lock(mutex), wtedy 1 funkcja mo�e czeka� na dane, kt�re dla niej stworzy 2 funkcja
//


namespace Locks
{
	using namespace std;

    mutex g_mutex;
	bool g_ready = false;
	condition_variable g_cv;
	int G_Data;
	int Data_Counter = 0;
	const int Data_to_send = 10;
	bool g_end = false;

	int GetRandomValue()
	{
		return rand() % 10000 + 1;
	}
	void Producer()
	{
		while (!g_end)
		{
			unique_lock<mutex> lock(g_mutex);
			G_Data = GetRandomValue();
			Data_Counter++;

			g_ready = true;
			lock.unlock();
			g_cv.notify_one();
			lock.lock();
			if (Data_Counter == Data_to_send)
			{
				g_end = true;
			    g_cv.notify_one();
			}
			g_cv.wait(lock, [&](){return g_ready == false; });
		}
	}

	void Consumer()
	{
		int data = 0;
		while (!g_end)
		{
			unique_lock<mutex> lock(g_mutex);
			g_cv.wait(lock, [&]() {return g_ready; });
			data = G_Data;
			cout << data << " Has been transported successfull\n";
			g_ready = false;
			lock.unlock();
			if (g_end)
			{
				cout << "End";
			}
			g_cv.notify_one();
			lock.lock();
		}
	}
       void LaunchProgram()
		{
		   /*
			vector<thread> Producers= { thread(Producer), thread(Producer), thread(Producer) };
			vector<thread> Consumers;
			for (int x = 0; x < 5; x++)
				Consumers.push_back(thread(Consumer));
		   */

		   //Code above and below doesnt work, i don't know reason why
		   thread t1(Producer);
		   thread c1(Consumer);
		   t1.join();
		   c1.join();

			/*

			for (auto& t : Producers)
			{
				if(t.joinable())
				t.join();
			}
			for (auto& t : Consumers)
			{
				if (t.joinable())
				t.join();
			}
			*/
		}
}
