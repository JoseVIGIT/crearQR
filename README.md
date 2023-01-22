# crearQR
Crear un QR usando consola en C#

## Paquetes necesarios
'''
dotnet add package ZXing.Net
dotnet add package ZXing.Net.Bindings.CoreCompat.System.Drawing --version 0.16.7-beta
'''
Usar ZXing en el código para poder tratar códigos QR y manejo de imagenes
'''
using ZXing;
using ZXing.QrCode;
using ZXing.CoreCompat.System.Drawing;
'''
## Ejecutar con parámetros en línea de comandos:
'''
dotnet run -- MiNombre 123
'''