macOS için:
Aşağıdaki komutu kullanarak yeni bir ASP.NET Core MVC projesi oluşturun: dotnet new mvc -n IrisReadingApp 
cd IrisReadingApp 
code .

Gerekli Paketleri Yükleme: IrisReadingApp projesinde JSON dosyalarını okuyup işleyebilmek için Microsoft.AspNetCore.Mvc.NewtonsoftJson paketini yükleyin:
dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson --version 6.0.0

dotnet restore
Bu komut, proje dosyalarınızdaki csproj dosyasına dayanarak tüm bağımlılıkları ve paketleri yükler. Genellikle yeni bir proje oluşturduğunuzda bu komut otomatik olarak çalıştırılmaz, bu yüzden elle çalıştırmanız gerekebilir.

çalıştırmak için:
dotnet build
dotnet run

aşağıdaki local host gibi, çıktı da yer alan adrese kendi bilgisayarınızda gidin.
http://localhost:5011/Iris
