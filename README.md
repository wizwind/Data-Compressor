# Data-Compressor
Lossless data compressor developed on C#. 

- Data compression has become the most important thing in the recent times. We have to
  compress huge amounts of data so as to carry from one place to other or in a storage format.
  That is why data has to be compressed.
- This proposed compression technique has improved the efficiency of file (like .txt, .docx, .pptx)
  compression using Huffman Approach with the concepts of LempelZiv, GZip and Deflate.
- In future, this type of software can help control the data boom.


# SYSTEM DESIGN

## Modules:
1) User Interface module  
  - Security Module  
  - Output module for Interface  
2) Format detection module
3) Compressor module 
4) Decompressor module

### User Interface Module
Simple user interface with the file uploading button.
a)Security Module:
The interface will be designed to take only the authentic file formats by providing less options and flexibility for uploading files.
b)Output module:
The files when undergo process of conversion the data is provided about the file size and process completion.It provides information about the file in runtime.


### Format Detection Module
The file format will be detected in this module and after the file will be compressed and change the format and save this module will be responsible for that change.
After every file conversion whenever the file changes its state the data is stored and used while decompression.
After the file is decompressed and the format needs to be changed again this module will do the job.

### Compressor Module
Compressor module will be used in the data compression.
It will consists the algorithms for the data compression.
The algorithm used will be huffman coding for the encoding followed by burrows wheeler transformation and lempel ziv.

### Decompressor Module
The file when undergoes the process of decompression uses this module and the algorithms used for the compression are used for the decompression.
Each time the algorithms convert the files into shorter files the format module comes into the process.

### Error Handling Module
In case of any error made by the user or the fault by a computer system the errors needs to be reported to sort the problem thus needing an error handling module.
Error handling will be used for providing better usability.
User errors via interface or errors from files all will be handled in the last stage of the software development.

### Output Module
This module comes into place whenever the files are compressed and are save in the location as choosen by the user.
Output module is also responsible for the changes in the interface to display the output and displaying the metadata such as the new size and the old size of the file and the compression ratio along with the time taken in the process.


