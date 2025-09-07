🖼️➡️📝 Convertir Imagen a Texto

Convertir Imagen a Texto es una aplicación de escritorio desarrollada en C# con Windows Forms que permite extraer texto de imágenes de manera rápida y sencilla usando OCR (Tesseract). Ideal para digitalizar documentos, capturas de pantalla o cualquier texto contenido en imágenes.

✨ Características principales

📷 Carga de imágenes: Compatible con formatos .jpg, .jpeg y .png.

🖊️ Extracción de texto: Obtén el texto contenido en cualquier imagen usando Tesseract OCR.

📝 Visualización inmediata: El texto extraído se muestra directamente en la aplicación.

🖥️ Interfaz simple e intuitiva: Fácil de usar, ideal para cualquier usuario.

❌ Manejo de errores: Notifica si la imagen seleccionada no es válida o hay un problema en el proceso.

🛠 Tecnologías utilizadas

Lenguaje: C#

Framework: .NET Windows Forms

OCR: Tesseract

IDE recomendado: Visual Studio

🚀 Cómo usar

Clona el repositorio:

git clone https://github.com/EMSAREES/convertir-imagen-a-texto.git


Abre el proyecto en Visual Studio.

Asegúrate de tener la carpeta tessdata descargada y ubicada en \bin\Debug del proyecto.

Compila y ejecuta la aplicación.

Selecciona una imagen y obtén el texto extraído automáticamente.

💡 Notas importantes

La extracción de texto está basada en Tesseract OCR, por lo que la precisión dependerá de la calidad de la imagen y del idioma configurado (eng por defecto).

Se pueden agregar más idiomas descargando los archivos .traineddata correspondientes.
