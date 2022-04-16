/*
//  Author: Jonathan Scholl
//  Date: 4/15/2022
//  Project: C#9 and .NET5 - Chapter09 - WorkingWithFileSystems
//  
*/
using System;
using System.IO;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;

namespace WorkingWithFileSystems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OutputFileSystemInfo();
            //WorkWithDrives();
            //WorkWithDirectories();
            WorkWithFiles();
        }
        //file system information
        static void OutputFileSystemInfo()
        {
            Console.WriteLine("{0,-33} {1}", "Path.PathSeparator", PathSeparator);
            Console.WriteLine("{0,-33} {1}", "Path.DirectorySeparatorChar", DirectorySeparatorChar);
            Console.WriteLine("{0,-33} {1}", "Directory.GetCurrentDirectory()", GetCurrentDirectory());
            Console.WriteLine("{0,-33} {1}", "Environment.CurrentDirectory", CurrentDirectory);
            Console.WriteLine("{0,-33} {1}", "Environment.SystemDirectory", SystemDirectory);
            Console.WriteLine("{0,-33} {1}", "Path.GetTempPath()", GetTempPath());
            Console.WriteLine("GetFolderPath(SpecialFolder");
            Console.WriteLine("{0, -33} {1}", " .System", GetFolderPath(SpecialFolder.System));
            Console.WriteLine("{0, -33} {1}", " .ApplicationData", GetFolderPath(SpecialFolder.ApplicationData));
            Console.WriteLine("{0, -33} {1}", " .MyDocuments", GetFolderPath(SpecialFolder.MyDocuments));
            Console.WriteLine("{0, -33} {1}", " .Personal", GetFolderPath(SpecialFolder.Personal));

        }
        //drive system information
        static void WorkWithDrives()
        {
            Console.WriteLine("{0, -30} | {1, -10} | {2, -7} | {3, 18} | {4,18}",
                "NAME", "TYPE", "FORMAT", "SIZE (BYTES)", "FREE SPACE");
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    Console.WriteLine("{0, -30} | {1, -10} | {2, -7} | {3, 18:N0} | {4, 18:N0}",
                        drive.Name, drive.DriveType, drive.DriveFormat, drive.TotalSize, drive.AvailableFreeSpace);
                }
                else
                {
                    Console.WriteLine("{0, -30} | {1, -10}",
                        drive.Name, drive.DriveType);
                }
            }
        }
        //working with directories
        static void WorkWithDirectories()
        {
            // define a directory path for a new folder
            // starting in the user's folder
            var newFolder = Combine(GetFolderPath(SpecialFolder.Personal), "Code", "Chapter09", "NewFolder");
            Console.WriteLine($"Working with: {newFolder}");
            // check if it exists
            Console.WriteLine($"Does it exists? {Exists(newFolder)}");
            //create directory
            Console.WriteLine("Creating it...");
            CreateDirectory(newFolder);
            Console.WriteLine($"Does it exists? {Exists(newFolder)}");
            Console.Write("Confirm the directory exists, and the press ENTER: ");
            Console.ReadLine();
            //delete directory
            Console.WriteLine("Deleting it...");
            Delete(newFolder, recursive: true);
            Console.WriteLine($"Does it exist? {Exists(newFolder)}");
        }
        static void WorkWithFiles()
        {
            // define a direcotry path to output files
            // starting in the user's folder
            var dir = Combine(GetFolderPath(SpecialFolder.Personal), "Code", "Chapter09", "OutputFiles");
            CreateDirectory(dir);
            //define file paths
            string textFile = Combine(dir, "Dummy.txt");
            string backupFile = Combine(dir, "Dummy.bak");
            Console.WriteLine($"Working with: {textFile}");
            //check if file exists
            Console.WriteLine($"Does it exists? {File.Exists(textFile)}");
            //create a new text file and write a line to it
            StreamWriter textWriter = File.CreateText(textFile);
            textWriter.WriteLine("Hello, C#!");
            textWriter.Close(); //close file and release resources
            Console.WriteLine($"Does it exists? {File.Exists(textFile)}");
            //copy the file, and overwrite if it already exists
            File.Copy(sourceFileName: textFile, destFileName: backupFile, overwrite: true);
            Console.WriteLine($"Does {backupFile} exists? {File.Exists(backupFile)}");
            Console.WriteLine("Confirm the files exist, and then press ENTER: ");
            Console.ReadLine();
            //delete file
            File.Delete(textFile);
            Console.WriteLine($"Does it exist? {File.Exists(textFile)}");
            //read from the text file backup
            Console.WriteLine($"Reading contents of {backupFile}: ");
            StreamReader textReader = File.OpenText(backupFile);
            Console.WriteLine(textReader.ReadToEnd());
            textReader.Close();
            //Managing paths
            Console.WriteLine($"Folder Name: {GetDirectoryName(textFile)}");
            Console.WriteLine($"File Name: {GetFileName(textFile)}");
            Console.WriteLine($"File Name without extension: {GetFileNameWithoutExtension(textFile)}");
            Console.WriteLine($"File Extension: {GetExtension(textFile)}");
            Console.WriteLine($"Random File Name: {GetRandomFileName()}");
            Console.WriteLine($"Temporary File Name: {GetTempFileName()}");
            
            var info = new FileInfo(backupFile);
            Console.WriteLine($"{backupFile}");
            Console.WriteLine($"Contain {info.Length} bytes");
            Console.WriteLine($"Last accessed {info.LastAccessTime}");
            Console.WriteLine($"Has readonly set to {info.IsReadOnly}");
        }
    }
}