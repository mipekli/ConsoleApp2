Console.WriteLine(" ");

byte b = 5;    //1 byte
sbyte c = 5;   //1 byte


short s = 5;   // 2byte
ushort us = 5; // 2byte

Int16 i16 = 2; // 2byte
int i = 2;     // 4byte 
Int32 i32 = 2; // 4byte
Int64 i64 = 2; // 8byte


uint ui = 2;  //4 byte
long l = 4;   //8 byte
ulong ul = 4;  //8 byte

//reel sayılar
float f = 5;  //4 byte 
double d = 5; //8 byte
decimal de = 5; //16 byte

char ch = '2'; // 2byte
string str = "Muhammed"; //sınırsız

bool b1 = true;
bool b2 = false;
DateTime dt = DateTime.Now;
Console.WriteLine(dt);

object o1 = "x";
object o2 = "y";
object o3 = 4;
object o4 = 4.3;

//string ifadeler

string str1 = string.Empty;
str1 = "Muhammed İpeklioğulları";
string ad = "Muhammed";
string soyad = "İpeklioğulları";
string tamisim = ad + " " + soyad;

// integer tanımlama şekilleri

int integer1 = 5;
int integer2 = 3;
int integer3 = integer1 * integer2;

//boollean

bool bool1 = 10 > 2;

// Değişken Dönüşümleri
string str20 = "20";
int int20 = 20;

string yeniDeger = str20 + int20.ToString();
Console.WriteLine(yeniDeger); // çıktısı 2020

int int21 = int20 + Convert.ToInt32(str20);
Console.WriteLine(yeniDeger); // çıktısı 40


int int22 = int20 + int.Parse(str20); // çıktısı 40

// DateTime

string datetime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(datetime);

string hour = DateTime.Now.ToString("HH:mm");
Console.Write(hour);   
