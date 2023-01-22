//Ejecutar con parámetros en línea de comandos:
//dotnet run -- MiNombre 123

//dotnet add package ZXing.Net
using ZXing;
using ZXing.QrCode;
//dotnet add package ZXing.Net.Bindings.CoreCompat.System.Drawing --version 0.16.7-beta
using ZXing.CoreCompat.System.Drawing;

//Incluye clase Dummy de nuestro proyecto definida al final de este fichero
using miQR;

//Lectura de parámetros pasados en línea de comando
string[] arguments = Environment.GetCommandLineArgs();

Dummy dummy = new Dummy();
dummy.nombre = "Ginebra";
dummy.edad = 45;
try {
    dummy.nombre = arguments[1];
    dummy.edad = int.Parse(arguments[2]);
} catch {}

var writer = new BarcodeWriter {
    Format = BarcodeFormat.QR_CODE,
    Options = new QrCodeEncodingOptions
    {
        Width = 250,
        Height = 250
    }
};
var qrCode = writer.Write
    ("Nombre = " + dummy.nombre+"\n" +
     "Edad   = " + dummy.edad);

qrCode.Save("qrCode.png");

namespace miQR {
    class Dummy {
        public string? nombre {get;set;}
        public int edad {get;set;}
    };
}