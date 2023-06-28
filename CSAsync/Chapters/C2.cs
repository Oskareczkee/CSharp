using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace CSAsync
{
    class AsciiArtWriter
    {

        //row, characters in a row
        private Dictionary<int, string> Image= new Dictionary<int, string>();
        public async Task LoadImage(string fileName)
        {
            List<string>lines= new List<string>();
            if (!File.Exists(fileName))
            {
                throw new Exception("File has not been found !");
            }
            using (StreamReader reader = new StreamReader(fileName))
            {
                for(int x=0;!reader.EndOfStream;x++)
                   lines.Add(reader.ReadLine());
            }
            for (int x = 0; x < lines.Count; x++)
                Image.Add(x, lines[x]);
        }


        //Threads are not synchronized !
        private void DrawLineParallel(int lineNumber)
        {
            Parallel.ForEach(Image[lineNumber], value =>
                {
                    Console.Write(value);
                }
            );
        }

        public void DrawLine(int lineNumber)
        {
            string line = string.Empty;
            Image.TryGetValue(lineNumber, out line);
            Console.WriteLine(line);
        }

        public void DrawImageNormalEdition()
        {
            if (Image is null)
                throw new Exception("Image has not been loaded !");

            foreach(var row in Image)
            {
                foreach (var character in row.Value)
                    Console.Write(character);
                Console.Write('\n');
            }    
        }

        public void DrawImage()
        {
                Parallel.For(0,Image.Count, element =>
                {
                    DrawLine(element);
                }
                );
        }


        //threads are not synchronized !
        public void DrawImageParallel()
        {
            if (Image is null)
                throw new Exception("Image has not been loaded !");

            Parallel.ForEach(Image, Image =>
            {
                DrawLineParallel(Image.Key);
            }

            );
        }
    }
}
