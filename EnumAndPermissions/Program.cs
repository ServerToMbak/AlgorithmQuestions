// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


    //0111              //0001             //0010                  //0100

    
var permission = FilePermission.Read | FilePermission.Write | FilePermission.Execute;
                
              //0111   ^    0010  => 0101 --> 5    // can not write anymore with this attribute  write:    false   
permission = permission ^ FilePermission.Write; 

permission = permission & ~FilePermission.Read; // we made Read as false

permission = permission | FilePermission.Write; // made writeable again wirite = true anymore

//0111         //0001                  //0001
var hasRead = (permission & FilePermission.Read) == FilePermission.Read; // & operator makes the same bit operator
                                                                         // 1 and different bits takes as 0 

//0111        //0010                    //0010
var hasWrite = (permission & FilePermission.Write) == FilePermission.Write;


var hasExecute = (permission & FilePermission.Execute) == FilePermission.Execute;



var hasAdmin = (permission & FilePermission.Admin) == FilePermission.Admin; //Will Return false

//0001 => 1110 --> 0110 --> 6 // Just different bits taken as 1 same bits taken as 0


var flagCheck = permission.HasFlag(FilePermission.Write);   

Console.WriteLine("Has write Flag method returns:" + flagCheck);

Console.WriteLine($"Read:\t{hasRead}\nWrite:\t{hasWrite}\nExecute:\t{hasExecute}\nAdmin:\t{hasAdmin}\t");
Console.WriteLine("Permission Value : " +  (int)permission);

Console.Read();

enum FilePermission
{ 
        None = 0, Read = 1, Write = 2, Execute = 4,  Admin= 8  
}    
