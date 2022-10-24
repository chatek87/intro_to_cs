// See https://aka.ms/new-console-template for more information
//Title adds title to console app window
Console.Title = "Charlie's First App!";

// This is like setting the "marker color" ofor the console. 
// Any text that we print out after this will be in the color we set.
Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.DarkMagenta;

// If we clear after setting the BG color, the window will be 
// covered in that color.
Console.Clear();

// Advanced: verbatim string.
// Allows us to print multi-line text!
// Font from text to ascii art generator (www.patorjk.com/software/taag)

Console.WriteLine(@" 

                                              ___                                                   
                                             (   )      .-.                                         
    .--.     ___  ___  ___   .--.     .--.    | |_     ( __)   .--.        .-..     .--.     .--.   
  /  _  \   (   )(   )(   ) /    \   /    \  (   __)   (''"")  /    \      /    \   /    \   /    \  
 . .' `. ;   | |  | |  | | |  .-. ; |  .-. ;  | |       | |  |  .-. ;    ' .-,  ; |  .-. ; |  .-. ; 
 | '   | |   | |  | |  | | |  | | | |  | | |  | | ___   | |  |  | | |    | |  . | | |  | | | |  | | 
 _\_`.(___)  | |  | |  | | |  |/  | |  |/  |  | |(   )  | |  |  |/  |    | |  | | | |  | | | |  | | 
(   ). '.    | |  | |  | | |  ' _.' |  ' _.'  | | | |   | |  |  ' _.'    | |  | | | |  | | | |  | | 
 | |  `\ |   | |  ; '  | | |  .'.-. |  .'.-.  | ' | |   | |  |  .'.-.    | |  ' | | '  | | | '  | | 
 ; '._,' '   ' `-'   `-' ' '  `-' / '  `-' /  ' `-' ;   | |  '  `-' /    | `-'  ' '  `-' / '  `-' / 
  '.___.'     '.__.'.__.'   `.__.'   `.__.'    `.__.   (___)  `.__.'     | \__.'   `.__.'   `.__.'  
                                                                         | |                        
                                                                        (___)                       


");


// WriteLine prints out a line of text to the console
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("HELLO");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(" there!");

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("This is Charlie!");

Console.WriteLine("Press any key to exit...");

// ReadKey waits for a key to be pressed. We use this here
// to keep the console window open until the user presses a key.
Console.ReadKey();
