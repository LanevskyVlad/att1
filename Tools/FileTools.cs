using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tools
{
    public class FileTools
    {
        public string Path { get; set; }
        private FileStream Stream;
        private BinaryWriter Writer;
        private BinaryReader Reader;
        public bool End
        {
            get
            {
                if (Reader == null)
                    throw new InvalidOperationException();
                return Stream.Position == Stream.Length;
            }
        }
        public void BinWriterOpen()
        {
            if (Reader != null)
                throw new InvalidOperationException();
            Stream = new FileStream(Path, FileMode.Create);
            Writer = new BinaryWriter(Stream);
        }

        public void BinReaderOpen()
        {
            if (Writer != null)
                throw new InvalidOperationException();
            Stream = new FileStream(Path, FileMode.Open);
            Reader = new BinaryReader(Stream);
        }

        public void Close()
        {
            Stream?.Close();
            Stream = null;
            Writer?.Close();
            Writer = null;
            Reader?.Close();
            Reader = null;
        }
        public string ReadText() => File.ReadAllText(Path);
        public void WriteText(string text) => File.WriteAllText(Path, text);
        public FileTools(string path) => Path = path;
        public void WriteBinList (List<double> list)
        {
            if (Writer == null)
                throw new InvalidOperationException();
            if (list == null)
                throw new ArgumentNullException();
            Writer.Write((byte)Type._double);//double флаг
            Writer.Write(list.Count);
            for (int i = 0; i < list.Count; i++)
            {
                Writer.Write(list[i]);
            }
        }
        public void WriteBinList(List<int> list)
        {
            if (Writer == null)
                throw new InvalidOperationException();
            if (list == null)
                throw new ArgumentNullException();
            Writer.Write((byte)Type._int);
            Writer.Write(list.Count);
            for (int i = 0; i < list.Count; i++)
            {
                Writer.Write(list[i]);
            }
        }
        public List<double> ReadBinListDouble()
        {
            if (Reader == null)
                throw new InvalidOperationException();
            if (Reader.ReadByte() != (byte)Type._double)
                throw new Exception("неверный формат данных");
            List<double> list = new List<double>();
            int N = Reader.ReadInt32();
            for (int i = 0; i < N; i++)
            {
                list.Add(Reader.ReadDouble());
            }
            return list;
        }
        public List<int> ReadBinListInt()
        {
            if (Reader == null)
                throw new InvalidOperationException();
            if (Reader.ReadByte() != (byte)Type._int)
                throw new Exception("неверный формат данных");
            List<int> list = new List<int>();
            int N = Reader.ReadInt32();
            for (int i = 0; i < N; i++)
            {
                list.Add(Reader.ReadInt32());
            }
            return list;
        }
        public void WriteBinList(List<Student> students)
        {
            if (Writer == null)
                throw new InvalidOperationException();
            if (students == null)
                throw new ArgumentNullException();
            Writer.Write((byte)Type.Student);
            Writer.Write(students.Count);
            for (int i = 0; i < students.Count; i++)
            {
                WriteStudent(students[i]);
            }
        }
        public List<Student> ReadBinStudentList()
        {
            if (Reader == null)
                throw new InvalidOperationException();
            if (Reader.ReadByte() != (byte)Type.Student)
                throw new Exception("неверный формат данных");
            List<Student> students = new List<Student>();
            int N = Reader.ReadInt32();
            for (int i = 0; i < N; i++)
            {
                students.Add(ReadStudent());
            }
            return students;
        }
        private void WriteStudent(Student student)
        {
            WriteStr(student.FIO);
            Writer.Write(student.Year.ToBinary());
            WriteBinList(student.MedB);
            Writer.Write(student.Kurs);
            Writer.Write(student.Group);
        }
        private Student ReadStudent()
        {
            string fio = ReadStr();
            DateTime Year = DateTime.FromBinary(Reader.ReadInt64());
            List<double> MedB = ReadBinListDouble();
            byte Kurs = Reader.ReadByte();
            byte Group = Reader.ReadByte();
            return new Student(fio, Year, MedB, Kurs, Group);
        }
        private void WriteStr(string s)
        {
            Writer.Write(s.Length);
            Encoder encoder = Encoding.Unicode.GetEncoder();
            byte[] bytes = new byte[s.Length * 2];
            encoder.GetBytes(s.ToCharArray(), 0, s.Length, bytes, 0, true);
            Writer.Write(bytes);
        }
        private string ReadStr()
        {
            int N = Reader.ReadInt32();
            byte[] bytes = Reader.ReadBytes(N * 2);
            Decoder decoder = Encoding.Unicode.GetDecoder();
            char[] data = new char[N];
            decoder.GetChars(bytes, 0, N * 2, data, 0);
            return new string(data);
        }

        private enum Type : byte
        {
            _double,
            _int,
            Student
        }
    }
}
