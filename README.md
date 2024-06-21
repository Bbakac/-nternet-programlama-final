IrisReadingApp adında dosya oluşturun daha sonra projeyi du dosya içinde kurun veya bütün dosyalar buradan alınarak proje oluşturulabilir.


macOS için projeyi oluşturma:
Aşağıdaki komutu kullanarak yeni bir ASP.NET Core MVC projesi oluşturun: dotnet new mvc -n IrisReadingApp 
cd IrisReadingApp 
code .

Gerekli Paketleri Yükleme:
IrisReadingApp projesinde JSON dosyalarını okuyup işleyebilmek için Microsoft.AspNetCore.Mvc.NewtonsoftJson paketini yükleyin:
dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson --version 6.0.0

dotnet restore
Bu komut, proje dosyalarınızdaki csproj dosyasına dayanarak tüm bağımlılıkları ve paketleri yükler. Genellikle yeni bir proje oluşturduğunuzda bu komut otomatik olarak çalıştırılmaz, bu yüzden elle çalıştırmanız gerekebilir.

çalıştırmak için:
dotnet build
dotnet run

aşağıdaki local host gibi, çıktı da yer alan adrese kendi bilgisayarınızda gidin.
http://localhost:5011/Iris



projeye dair:
vscode için:
Yeni bir MVC Ef core 6.0 projesi oluşturun. aşağıdakileri yapın:
1.Eklentideki json dosyasını bir action metodu aracılığıyla okutarak içeriğini view'a gönderin.
2.iris.json dosyasının içeriğini görüntülediğiniz View ı kendiniz belirleyeceğiniz bir layout ile oluşturun(tasarım serbest. Örneğin sadece renk kullanabilirsiniz)
iris.json
