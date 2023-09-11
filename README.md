# NorthwindWindowsFormApp

Kullanılan Veri Tabanı Northwind Veritabanı

Kullanılan Teknolojiler: Visual Studio WindowsForm, Dapper

Kullanılan Pattern: RepositoryPattern

Ana Panel üzerinden Northwind'in product, category, supplier, customer, employee, shipper, order ve order detail tablolarını kullanarak yönetici paneli oluşturuldu.

orderdetail hariç tüm tabloların entity ve repository sınıfları vardır. order detail'ın sadece entity sınıfı vardır.

category, supplier, employee ve shipper kısımlarında yeni kayıt oluşturma ve kayıtlı kayıtlarını gösterme menu buttonları vardır. Veritabanında bulunduğu tabloda(category,supplier vs.) yeni kayıt oluşturulabilir ya da var olan kayıt listeleri Datagridview üzerinde görüntülenebilir. görüntülenen listelere sağ tıklandığında update ve remove kısımları mevcuttur. Update tıklandığında ilgili Update formu açılır ve hangi kayıt sağ tıklanıp update buttonuna tıklandı ise o kayıt bilgileri görüntülenir. ister kayıt bilgileri değiştirilmeden istenirse değiştirilerek alttaki button'a tıklandığında kayıt güncellenir. Remove tıklandığında ise kayıt silinir bu iki işlem sonucunda Datagridview otomatik olarak yenilenir.

customer tablosunun üsteki açıklamalardan tek farkı ise Northwind veritabanında customerID string olarak bulunuyor. Otomatik bir artışı bulunmuyor. Yeni bir customer oluşturulurken customerID'nin de oluşturulması gerekiyor. Bu durumdan dolayı yeni kayıt oluşturulurken kendi oluşturduğum basit bir algoritma yardımı ile CustomerRepository içerisinde CreateID methodunu kullanarak customerID'yi oluşturuyorum.

product tarafın tek farkı ise product tablosunda UnitsInStock, UnitsOnOrder, ReorderLevel şeklinde kolonları vardır. Bunlara göre siparişi beklenen ve siparişi verilmemiş ReOrderLevel'in altındaki ürünleri gösteren form mevcuttur. Bu kısımda ViewModel kullanılmıştır.

order detail tablosunda product ve order many-to-many bağlantı olduğundan Order ve order detail tabloları ortak olarak hazırlanmıştır. Önce order oluşturularak order details oluşturulmaktadır. Yeni order formunda Product ekle buttonuna basılarak istendiği kadar product eklenebilir. Aynı product eklenirken var olanın miktarı artar. Yeni product ekleme event yapıları yardımıyla yapılmıştır. Ayrıca burada da ViewModel oluşturulmuştur.
