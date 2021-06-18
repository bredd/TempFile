# TempFile

A simple class that manages the lifetime of a temporary file.

CodeBit URL: [https://raw.githubusercontent.com/bredd/TempFile/main/TempFile.cs](https://raw.githubusercontent.com/bredd/TempFile/main/TempFile.cs)

## About TempFile
The class implements IDisposable and, when disposed, automatically deletes the temp file.
The file is created using System.IO.Path.GetTempFileName();

The software is distributed in C# as a [CodeBit](http://filemeta.org/CodeBit.html).

<strong>License:</strong> [Unlicense](http://unlicense.org)

## About CodeBits
A [CodeBit](https://www.FileMeta.org/CodeBit.html) is a way to share common code that's lighter weight than NuGet. Each CodeBit consists of a single source code file. A structured comment at the beginning of the file indicates where to find the master copy so that automated tools can retrieve and update CodeBits to the latest version.