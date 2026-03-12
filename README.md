# ✈️ Uçaksavar Savunma Oyunu

C# ile geliştirilmiş, nesne yönelimli mimari kullanılarak tasarlanmış masaüstü tabanlı uçaksavar savunma oyunu.

## 🎮 Oyun Hakkında

Ekranın altında bulunan **uçaksavarı** kontrol ederek yukarıdan gelen düşman uçaklarını düşür!  
Uçaklar tabandaki **savunma paneline** ulaşmadan önce onları mermiyle imha et.  
Sağ üstteki **süre sayacı** ile ne kadar savaştığını gör!

## 🕹️ Nasıl Oynanır?

| Kontrol | Açıklama |
|--------|----------|
| `Enter` | Oyunu başlat |
| ⬅️ ➡️ Ok Tuşları | Uçaksavarı sağa/sola hareket ettir |
| `Space` | Mermi ateşle |

- Düşman uçaklar yukarıdan aşağıya doğru iner.
- Uçaklardan biri **savunma paneline çarparsa** oyun sona erer.

## 🏗️ Proje Yapısı
```
savas-oyunu/
│
├── Savas.Desktop/
│   ├── AnaForm.cs           # Ana oyun ekranı (Windows Forms)
│   └── Program.cs           # Giriş noktası
│
├── Savas.Library/
│   ├── Abstract/
│   │   └── Cisim.cs         # Tüm oyun nesneleri için temel soyut sınıf
│   │
│   ├── Concrete/
│   │   ├── Mermi.cs         # Mermi hareketi ve davranışı
│   │   ├── Oyun.cs          # Oyun döngüsü ve kuralları
│   │   ├── Ucak.cs          # Düşman uçak davranışı
│   │   └── Ucaksavar.cs     # Oyuncu kontrolündeki uçaksavar
│   │
│   ├── Enum/
│   │   └── Yon.cs           # Hareket yönü (Sol, Sağ, Yukarı, Aşağı)
│   │
│   └── Interface/
│       ├── IHareketEden.cs  # Hareket edebilen nesneler için arayüz
│       └── IOyun.cs         # Oyun mantığı için arayüz
│
└── Savas.sln
```

## 🧠 Mimari & OOP Tasarımı

Bu proje aşağıdaki nesne yönelimli programlama prensiplerini uygular:

- **Soyutlama:** `Cisim` abstract sınıfı tüm oyun nesnelerinin (Uçak, Mermi, Uçaksavar) ortak özelliklerini tanımlar.
- **Kalıtım:** `Ucak`, `Mermi`, `Ucaksavar` sınıfları `Cisim`'den türetilmiştir.
- **Arayüz Kullanımı:** `IHareketEden` ile hareket edebilen nesneler sözleşmeye bağlanmış, `IOyun` ile oyun akışı arayüze taşınmıştır.
- **Katmanlı Mimari:** Oyun mantığı (`Savas.Library`) ile arayüz (`Savas.Desktop`) birbirinden bağımsız tutulmuştur.
- **Enum Kullanımı:** `Yon.cs` ile yön değerleri tip güvenli biçimde yönetilmiştir.

## 🛠️ Kullanılan Teknolojiler

- **Dil:** C#
- **Platform:** Windows Forms (.NET)
- **IDE:** Visual Studio
- **Prensipler:** OOP, SOLID, Katmanlı Mimari

## 🚀 Kurulum & Çalıştırma

1. Repoyu klonlayın:
```bash
   git clone https://github.com/hakan-tosun/savas-oyunu.git
```
2. `Savas.sln` dosyasını **Visual Studio** ile açın.
3. `Savas.Desktop`'ı başlangıç projesi olarak ayarlayın.
4. `Ctrl + F5` ile başlatın.

## 📋 Gereksinimler

- Visual Studio 2019+
- .NET Framework 4.7+ veya .NET 6+

## 👤 Geliştirici

**Hakan Tosun**  
GitHub: [@hakan-tosun](https://github.com/hakan-tosun)
