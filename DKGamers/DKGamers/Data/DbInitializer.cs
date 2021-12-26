using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DKGamers.Models;

namespace DKGamers.Data
{
    public static class DbInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
                modelBuilder.Entity<Haber>().HasData(
                new Haber()
                {
                    HaberID = 5,
                    HaberBaslik = "Steam, 2020'nin En Çok Satan Oyunlarını Açıkladı",
                    HaberResim = "haber1.jpg",
                    HaberIcerik = "Dünyanın en büyük dijital oyun mağazası olan Steam, 2020'nin en iyileri listesini yayınladı. " +
                    "Listeye göre brüt gelirler ölçülen 2020'nin en çok satan 12 Steam oyunu;" +
                    "– Dota 2," +
                    "- Grand Theft Auto V," +
                    "– Red Dead Redemption 2," +
                    "– Cyberpunk 2077," +
                    "– Playerunknown’s Battlegrounds," +
                    "– Doom Eternal," +
                    "– Monster Hunter World," +
                    "- Rainbow Six: Siege," +
                    "– Destiny 2," +
                    "– Fall Guys: Ultimate Knockout," +
                    "– Counter - Strike: Global Offensive ve " +
                    "– Among Us oldu." +
                    "Listeye göre 2020'nin en çok oynanılan oyunlarıysa;" +
                    "– Dota 2," +
                    "– Among Us," +
                    "– Terraria," +
                    "– Cyberpunk 2077," +
                    "– Life is Strange 2," +
                    "– Monster Hunter World," +
                    "– Counter - Strike: Global Offensive," +
                    "– Mount & Blade 2: Bannerlord," +
                    "– Destiny 2," +
                    "– Playerunknown’s Battlegrounds ve " +
                    "– Grand Theft Auto V oldu.",
                },

                new Haber()
                {
                    HaberID = 4,
                    HaberBaslik = "CD PROJEKT RED'e Cyberpunk 2077 Yüzünden İlk Dava Açıldı",
                    HaberResim = "haber2.jpg",
                    HaberIcerik = "Video oyun sektörünün son dönemlerdeki en çok tartışılan ismi, CD PROJEKT RED. Bunun nedeniyse, kısa bir süre önce piyasaya sürülen Cyberpunk 2077. Oyunda yaşanan sorunlar, şirketin oldukça ağır bir şekilde eleştirilmesine yol açtı." +
                    " Ancak şirket, sadece eleştirileri yutmak zorunda kalmayacak. Çünkü Rosen Law isimli bir şirket, CD PROJEKT RED'den davacı oldu. Rosen Law isimli hukuk şirketi tarafından açılan davaya göre CD PROJEKT RED, Cyberpunk 2077'yi piyasaya sürmeden önce, " +
                    "oyuncuları ve yatırımcıları yanlış yönlendirdi. Şirket aslında, oyunun ne halde olduğunu biliyordu ancak bunu gizledi. Bu sayede de Cyberpunk 2077'nin hype'lanmaya devam etmesine neden olan CD PROJEKT RED, bir nevi haksız kazanç elde etmiş oldu. " +
                    "Rosen Law tarafından açılan davanın şu an için bilindik bir katılımcısı yok. Ancak şirket, özellikle de yatırımcıların bu davaya dahil olmaları gerektiğini, hisse senedi değerlerinin ortada olduğunu ifade ediyor. Ayrıca dileyen oyuncuların da davaya dahil " +
                    "olabileceğini söyleyen hukuk şirketi, davaya dahil olmak isteyenlere de bir çevrimiçi form sunuyor. Yaşanan olay, CD PROJEKT RED için bir ilk niteliğinde. Ancak bu durum, son olmayabilir. Çünkü geliştirici şirketin ana vatanı olan Polonya'da da yatırımcılar, " +
                    "şirkete karşı yaptırım planları üzerinde yoğunlaşmış durumdalar. Tüm bu olayların nasıl sonuçlanacağı bilinmiyor ancak CD PROJEKT RED'i oldukça zorlu günlerin beklediğini şimdiden söyleyebiliriz."
                },

                new Haber()
                {
                    HaberID = 3,
                    HaberBaslik = "The Forest'ın Devam Oyunu Sons Of The Forest İçin Yeni Fragman Yayınlandı",
                    HaberResim = "haber3.jpg",
                    HaberIcerik = "Macera türündeki Sons Of The Forest oyunu için dikkat çekici yeni bir oynanış videosu daha yayınlandı. Hatırı sayılır bir hayran kitlesine sahip olan The Forest oyununun devamı niteliğinde karşımıza çıkacak olan Sons Of The Forest, hem görsel yöndeki gelişimi" +
                    " hem de oynanış dinamikleri ile türü seven oyuncuları yine memnun edeceğe benziyor. Endnight Games ekibi tarafından geliştirilen Sons Of The Forest, 2021 yılında çıkacak.Net bir çıkış tarihi belli olmayan oyun Unity grafik motoru kullanılarak geliştiriliyor.Görsel olarak oldukça " +
                    "hoş gözüken oyunun yapım ekibi hem işleme hem de ışıklandırma gibi noktalarda önemli geliştirmeler yapıldığını belirtmiş.Bu sayede oyunun değişken hava şartlarının çok daha iyi gözükeceği gelen bilgiler arasında. Zaten yayınlanan oynanış videosuna baktığımızda da karlı alanların ve değişen" +
                    " hava şartlarının gerçekten de güzel gözüktüğünü fark ediyoruz. İlk oyunda olduğu gibi inşa etme dinamiklerinin oldukça önemli olduğu Sons Of The Forest oyununda yeni inşa seçenekleri ve düşman çeşitleri de bulunacak. Oyunda yakın dövüş dinamiklerine daha fazla ağırlık verilecek."
                },

                new Haber()
                {
                    HaberID = 2,
                    HaberBaslik = "Steam'de Anlık Oyuncu Sayısında Rekor Kırıldı",
                    HaberResim = "haber4.jpg",
                    HaberIcerik = "Koronavirüsün de etkisiyle hafta sonunu evde geçiren milyonlarca oyun sever, Steam’e akın etti. Ünlü oyun platformunda 24 milyon 804 bin 148 kullanıcı aynı anda aktif oldu. 25 milyona yakın kullanıcının Steam’de aktif olmasında en büyük etkenlerinden biri, uygulamanın bilgisayar açılınca" +
                     " otomatik aktif olması. Ancak Steam, anlık oyuncu sayısında da 7 milyonu görerek kendi rekorunu bir kez daha kırdı. 25 milyon kullanıcı içinde Steam’de oyun oynayan 7 milyon kişinin oynadıkları oyunların başında Counter-Strike: Global Offensive(1.062.017 kullanıcı), Cyberpunk 2077(1.047.602 kullanıcı) ve " +
                     "Playerunknown’s Battlegrounds(648.889 kullanıcı) bulunuyor. Tek oyunculu bir oyun olmasına rağmen neredeyse CS:GO ile aynı oyuncu sayısına erişen Cyberpunk 2077 ise anlık olarak 654.963 oyuncu sayısına ulaştı.Steam’in bundan önceki rekoru koronavirüsün dünya çapında yayılmaya başladığı aylarda gelmişti.Mart 2020‘de 22 milyon" +
                     " anlık kullanıcıya erişen Steam, üst üste 3 defa rekor kırmıştı."
                },

                new Haber()
                {
                    HaberID = 1,
                    HaberBaslik = "The Game Awards 2020 Kazananları Açıklandı",
                    HaberResim = "haber5.jpg",
                    HaberIcerik = "Dünyanın en büyük video oyun ödül organizasyonlarından bir tanesi olan The Game Awards 2020 etkinlikleri, Türkiye saati ile gece 03:00 sularında gerçekleşti. 2020'nin en'lerinin seçildiği seçildiği etkinlikler kapsamında da herkesin tahmin edebileceği bazı oyunlar, çeşitli ödüllere layık görüldü.İşte The Game Awards 2020'nin tüm kazananları:" +
                    "Yılın Oyunu: The Last of Us: Part II " +
                    "Oyuncunun Sesi: Ghost of Tsushima " +
                    "En İyi Oyun Yönetmenliği: The Last of Us: Part II " +
                    "En İyi Anlatı: The Last of Us: Part II " +
                    "En İyi Sanat Yönetmenliği: Ghost of Tsushima " +
                    "En İyi Ses Tasarımı: The Last of Us: Part II " +
                    "En İyi Müzik: Final Fantasy VII " +
                    "RemakeKarakterler Bazında En İyi Performans: The Last of Us: Part II " +
                    "En Çok Etkileyen Oyun: Tell Me Why " +
                    "Devam Etmekte Olan En İyi Oyun: No Man's Sky " +
                    "En İyi Indie Oyun: Hades " +
                    "En İyi Mobil Oyun: Among Us " +
                    "En İyi Topluluk Desteği Veren Oyun: Fall Guys: Ultimate Knockout " +
                    "En İyi Sanal Gerçeklik/Artırılmış Gerçeklik Oyunu: Half - Life: Alyx " +
                    "En İyi Erişilebilirlikte Yenilik Oyunu: The Last of Us: Part II " +
                    "En İyi Aksiyon Oyunu: Hades " +
                    "En İyi Aksiyon/Macera Oyunu: The Last of Us: Part II " +
                    "En İyi RPG Oyunu: Final Fantasy VII Remake " +
                    "En İyi Dövüş Oyunu: Mortal Kombat 11 Ultimate " +
                    "En İyi Aile Oyunu: Animal Crossing: New Horizons " +
                    "En İyi Simülasyon/Strateji Oyunu: Microsoft Flight Simulator " +
                    "En İyi Spor/Yarış Oyunu: Tony Hawk’s Pro Skater 1 + 2 " +
                    "En İyi Çok Oyunculu Oyun: Among Us " +
                    "En Çok Beklenen Oyun: Elden Ring " +
                    "En İyi İçerik Üreticisi: Valkyrae " +
                    "En İyi Çıkış Yapan Oyun: Phasmophobia " +
                    "En İyi E-spor Oyunu: League of Legends " +
                    "En İyi E-spor Takımı: G2 " +
                    "EsportsEn İyi E-spor Etkinliği: League of Legends"
                }
            );

            modelBuilder.Entity<Oyun>().HasData(
                new Oyun()
                {
                    OyunID = 1,
                    Resim = "oyun1.jpg",
                    OyunAdi = "Hades",
                    PiyasayaSurulmeTarihi = new DateTime(2018, 12, 6),
                    Yayinci = "Supergiant Games",
                    Gelistirici = "Supergiant Games",
                    Aciklama = "Oyun Hades’in oğlu Zagreus’un babasına baş kaldırmasını konu almaktadır. Zagreus babasına yeraltı dünyasından çıkacağını söyler. " +
                    "Babasını bunu başaramayacağını söylese de Zagreus yeraltı dünyasından çıkmak için yola koyulur. Bu yolculukta Zagreus’un karşısına birçok zorlu düşman çıkacaktır. " +
                    "Oyuncular Zagreus’u yöneterek zorlu düşmanlarla savaşacak; elde edindikleri yeni eşyalarla güçlenmeye ve Zagreus’un amacına ulaşmasını sağlamaya çalışacaktır.",
                    GoruntulenmeSayisi = 814
                },
                new Oyun()
                {
                    OyunID = 2,
                    Resim = "oyun2.jpg",
                    OyunAdi = "Grand Theft Auto V",
                    PiyasayaSurulmeTarihi = new DateTime(2013, 9, 17),
                    Yayinci = "Rockstar Games",
                    Gelistirici = "Rockstar North",
                    Aciklama = "Oyun Kaliforniya eyaletinin güneyini temel alarak oluşturulmuş olan San Andreas eyaletinde geçmektedir. " + 
                    "San Andreas, büyük ölçüde Los Angeles şehrine dayanılarak oluşturulmuş olan Los Santos adlı şehirden (GTA San Andreas oyunundakinin güncellenmiş hali) ve büyük kırsal alanlardan oluşmaktadır. " + 
                    "Seride bir ilk olarak oyunda üç ana karakter bulunmaktadır: Michael De Santa, Trevor Philips ve Franklin Clinton.  Oyundaki üç karakterden her birinin farklı alanlarda farklı yetenekleri ve güçleri vardır. " + 
                    "Oyuncular tek oyunculu modda oyunun hikayesini oynayarak ya da çok oyunculu modda kendi oluşturdukları karakterlerle başka oyuncularla oynayarak zaman geçirebilirler.",
                    GoruntulenmeSayisi = 1536
                },
                new Oyun()
                {
                    OyunID = 3,
                    Resim = "oyun3.jpg",
                    OyunAdi = "Tom Clancy's Rainbow Six Siege",
                    PiyasayaSurulmeTarihi = new DateTime(2015, 12, 1),
                    Yayinci = "Ubisoft",
                    Gelistirici = "Ubisoft Montreal",
                    Aciklama = "Tom Clancy's Rainbow Six Siege, oyuncuların bir anti-terörist birimi olan Rainbow takımından değişik operatörler olarak oynayabileceği birinci şahıs nişancı türünde bir video oyunudur. " + 
                    "Bu operatörlerin değişik uyrukları, ekipmanları, yetenekleri ve işlevleri vardır. Oyunda takım çalışması kuşatma anlamına gelen Siege ismiyle desteklenirken, oyuncuların düşmanlarını yenebilmesi için güçlerini birleştirmeleri amaçlanmıştır. " + 
                    "Aynı zamanda oyuncular arasındaki iletişimi güçlendirmek için oyun içinde sesli olarak iletişim sağlanabilmektedir. Oyuncular aynı zamanda oyun başlamadan önce saldırılarının veya savunmalarının ne şekilde olacağıyla ilgili plan yapabilmektedir. " + 
                    "Saldırı takımı çevreyi araştırmak, düşmanlarının ve hedeflerin yerlerini tespit edebilmek için küçük dronelar gönderebilirken, savunma takımı da saldırıyı önleyebilmek için kapı, duvar gibi yapıları güçlendirmek amacıyla çeşitli barikatlar döşeyebilmektedir. " +
                    "Saldırı takımı, saldırı için birden fazla başlama noktasından birini seçebilmektedir. Oyundaki haritalar çok büyük değildir.", 
                    GoruntulenmeSayisi = 659
                },
                new Oyun()
                {
                    OyunID = 4,
                    Resim = "oyun4.jpg",
                    OyunAdi = "Metro Exodus",
                    PiyasayaSurulmeTarihi = new DateTime(2019, 2, 15),
                    Yayinci = "Deep Silver",
                    Gelistirici = "4A Games",
                    Aciklama = "4A Games'in hazırladığı Metro Exodus, en sürükleyici oyun dünyalarından birinde ölümcül dövüşleri ve gizliliği, keşif ve hayatta kalma korkusuyla birleştiren destansı, hikaye tabanlı bir birinci şahıs nişancı oyunudur. " +
                    "Dmitry Glukhovsky'nin romanlarından esinlenilmiştir.Oyun 2036 yılında geçmektedir.Oyunda nükleer savaşın dünyayı mahvetmesinin üstünden çeyrek yüzyıl geçmiştir, hayatta kalan birkaç bin kişi Moskova'nın harabelerinin altında, Metro tünellerinde hayatta kalmaya çalışmaktadır. " +
                    "Bu kişiler zehirli elementlere dayanmış, mutant yaratıklarla ve doğa üstü korkularla savaşmış, iç savaşın yaralarını tatmışdır. Oyunun amacı , Artyom olarak Metro'dan kaçmak ve Doğuda yeni bir yaşam aramak için kıyamet sonrası vahşi Rus doğasında geçen inanılmaz bir macerada bir grup Spartalı Korucuya öncülük etmektir.",
                    GoruntulenmeSayisi = 278
                },
                new Oyun()
                {
                    OyunID = 5,
                    Resim = "oyun5.jpg",
                    OyunAdi = "Sea of Thieves",
                    PiyasayaSurulmeTarihi = new DateTime(2017, 4, 20),
                    Yayinci = "Xbox Game Studios",
                    Gelistirici = "Rare Ltd",
                    Aciklama = "Sea of Thieves, birinci şahıs bakış açısıyla oynanan, korsan temalı bir aksiyon-macera kooperatifi çok oyunculu oyunudur. " +
                    "Bir grup oyuncu bir korsan gemisi vasıtasıyla açık bir dünyayı dolaşıp keşfetmekte ve direksiyon, kaldırma yelkenleri, navigasyon, ateş topları ve diğer görevler gibi farklı roller üstlenmektedir. " +
                    "Oyuncular araştırmalara başlar, yağma tutar ve diğer oyuncularla savaşa girerler. Thieves Denizi, oyuncuların gruplarının maceraları boyunca düzenli olarak karşılaşacakları ortak bir dünya oyunu. " +
                    "Oyun, karikatürize bir sanat stiline ve oyuncuların gemi toplarına atılmasına izin veren abartılı fizik özelliklerine sahiptir.",
                    GoruntulenmeSayisi = 777
                },
                new Oyun()
                {
                    OyunID = 6,
                    Resim = "oyun6.jpg",
                    OyunAdi = "Cyberpunk 2077",
                    PiyasayaSurulmeTarihi = new DateTime(2020, 12, 10),
                    Yayinci = "CD Projekt Red",
                    Gelistirici = "CD Projekt Red",
                    Aciklama = "Cyberpunk 2077 güç, gösteriş ve vücut modifikasyonu çılgınlığına kapılmış Night City kümekentinde geçen bir açık dünya aksiyon macera hikâyesidir. " +
                    "Kanun kaçağı paralı asker V olarak oyna ve ölümsüzlüğün anahtarı olan eşsiz bir implantın peşine düş. Karakterinin sibergereçlerini, yeteneklerini ve oynanış stilini özelleştir; kararların hikâyeyi ve dünyayı değiştirdiği devasa bir şehri keşfet.",
                    GoruntulenmeSayisi = 2956
                },
                new Oyun()
                {
                    OyunID = 7,
                    Resim = "oyun7.jpg",
                    OyunAdi = "Hearts of Iron IV",
                    PiyasayaSurulmeTarihi = new DateTime(2016, 6, 6),
                    Yayinci = "Paradox Interactive",
                    Gelistirici = "Paradox Development Studio",
                    Aciklama = "Hearts of Iron IV Paradox Development Studio tarafından geliştirilen ve Paradox Interactive tarafından yayımlanan strateji oyunudur. " +
                    "Hearts of Iron III'ün devam oyunudur, diğer Hearts of Iron serisi oyunları gibi II. Dünya Savaşına odaklanır. Oyuncular 1936 ve 1939 olmak üzere iki başlangıç tarihinden birini seçebilir. " +
                    "Daha sonra oyuncular oyuna başlamak için ülke seçer. Oyuncuların amacı seçtikleri ülkeyle savaşta zafer almaya çalışmaktır. Bu amaca ulaşmak için oyuncuların ülkelerini doğru yönetmesi ve geliştirmesi gerekmektedir. ",
                    GoruntulenmeSayisi = 1267
                },
                new Oyun()
                {
                    OyunID = 8,
                    Resim = "oyun8.jpg",
                    OyunAdi = "Mount & Blade II: Bannerlord",
                    PiyasayaSurulmeTarihi = new DateTime(2020, 3, 30),
                    Yayinci = "TaleWorlds Entertainment",
                    Gelistirici = "TaleWorlds Entertainment",
                    Aciklama = "Mount & Blade II: Bannerlord, orta çağ savaş simülasyon ve rol-yapma oyunu olan Mount & Blade: Warband’in heyecanla beklenen devamı niteliğindedir. " +
                    "200 yıl öncesinde geçen, detaylı dövüş sistemini ve Kalradya dünyasını daha kapsamlı ele alır. Dağlardaki sığınakları talan edin, şehirlerin arka sokaklarında gizli suç imparatorlukları kurun ya da güç mücadelenizde savaş keşmekeşinin içine atılın. " +
                    "Engin Kalradya kıtasında keşfe çıkın, baskınlar düzenleyin ve yolunuz boyunca dostlar düşmanlar edinin. Kendi ordunuzu yetiştirip savaşa sokun; bir yandan birliklerinizi komuta ederken diğer yandan onların yanında aksiyonun kalbine dalıp düşmanla çarpışın.",
                    GoruntulenmeSayisi = 1453
                },
                new Oyun()
                {
                    OyunID = 9,
                    Resim = "oyun9.jpg",
                    OyunAdi = "Football Manager 2021",
                    PiyasayaSurulmeTarihi = new DateTime(2020, 11, 10),
                    Yayinci = "SEGA",
                    Gelistirici = "Sports Interactive",
                    Aciklama = "Bir menajerlik oyunudur. Oyuncular istedikleri takımı alır ve yönetir. Oyunun amacı, seçtiğin takımı dünyanın en iyi takımı yapmak ve şampiyonluklar yaşamaktır. " +
                    "Oyuncular altyapıdan oyuncu yetiştirme, takım taktiğini belirleme, oyuncu transfer etme gibi işlemleri yapabilir.",
                    GoruntulenmeSayisi = 853
                },
                new Oyun()
                {
                    OyunID = 10,
                    Resim = "oyun10.jpg",
                    OyunAdi = "Papers, Please",
                    PiyasayaSurulmeTarihi = new DateTime(2013, 8, 8),
                    Yayinci = "3909",
                    Gelistirici = "Lucas Pope",
                    Aciklama = "Oyunda oyuncular 1982'nin sonlarında, Arstotzka isimli komünist bir ülkedeki bir vize memurunu yönetmektedir. Oyuncuların oyunda yaptıkları tek şey gelen insanları ülkeye almak ya da almamak. " +
                    "Oyuncular ülkeye birisini alırken çok dikkatli olmalıdır. Çünkü aldıkları kişi bir casus, bir terörist olabilir. Oyuncular gün sonunda yaptıkları işlem sayısına göre para kazanmaktadır. " +
                    "Kazandıkları bu parayla da ailelerine bakmaya çalışırlar.",
                    GoruntulenmeSayisi = 293
                },
                new Oyun()
                {
                    OyunID = 11,
                    Resim = "oyun11.jpg",
                    OyunAdi = "Crusader Kings III",
                    PiyasayaSurulmeTarihi = new DateTime(2020, 9, 1),
                    Yayinci = "Paradox Interactive",
                    Gelistirici = "Paradox Development Studio",
                    Aciklama = "Oyun, önceki oyunları Crusader Kings ve Crusader Kings II gibi, Orta Çağ'da geçen bir strateji ve hanedan simülasyonu oyunudur. " +
                    "Viking Çağı'ndan Bizans'ın Düşüşüne kadar devam etmektedir. Karakterler, 2D portreler yerine tam gövdeli, 3D olarak oluşturulmuş karakter modellerine sahiptir. " +
                    "Crusader Kings II'de olduğu gibi, istatistiklerini ve davranışlarını etkileyen özelliklere sahiptirler. Bir karakterin özelliklerine aykırı seçimler yapmak, o karakterin stresini artıracaktır. " +
                    "Oyunun genetik sistemi, karakterlerin bazı özelliklerini torunlarına aktarmalarına izin veriyor. Karakterler takip etmek için beş yaşam tarzından birini seçebilirler. " +
                    "Her yaşam tarzının, karakterlerin o yaşam tarzıyla ilgili becerileri geliştirmesine izin veren üç beceri ağacı vardır. ",
                    GoruntulenmeSayisi = 1089
                },
                new Oyun()
                {
                    OyunID = 12,
                    Resim = "oyun12.jpg",
                    OyunAdi = "Dead by Daylight",
                    PiyasayaSurulmeTarihi = new DateTime(2016, 6, 14),
                    Yayinci = "Behaviour Interactive Inc.",
                    Gelistirici = "Behaviour Interactive Inc.",
                    Aciklama = "Dead by Daylight, çok heyecanlı ve oldukça rekabetçi, korku ve gerilim ögelerine sahip bir hayatta kalma ve gizlilik oyunudur. " +
                    "Oyunda bir kişi katil, dört kişi ise katilden kaçmaya çalışan kişileri oluşturuyor. Burada amaç, katilden kaçarak hayatta kalmak. " +
                    "Oyunda dilerseniz hayatta kalmaya çalışan birini oynayabilir, dilerseniz de onları öldürmeye çalışan katili oynayabilirsiniz. " +
                    "Oyunda katil olmak veya hayatta kalmaya çalışmanın yanı sıra, arkadaşlarınızla hayatta kalma modu sayesinde rastgele bir katil oyuncu ile karşılaşıp arkadaşlarınızla beraber hayatta kalmaya çalışabilirsiniz. " +
                    "Arkadaşlarını öldür modunda ise sadece arkadaşlarınızla karşılaşırsınız, ancak bu modda seviye kazanılmaz.",
                    GoruntulenmeSayisi = 952
                },
                new Oyun()
                {
                    OyunID = 13,
                    Resim = "oyun13.jpg",
                    OyunAdi = "Frostpunk",
                    PiyasayaSurulmeTarihi = new DateTime(2018, 4, 24),
                    Yayinci = "11 Bit Studios",
                    Gelistirici = "11 Bit Studios",
                    Aciklama = "Frostpunk, ısının yaşam anlamına geldiği ve her kararın bir bedelinin olduğu bir toplum olarak hayatta kalma oyunu. " +
                    "Tamamen donmuş bir dünyada, insanlar karşı konulamaz soğukla başa çıkabilmek için buhar gücü teknolojisini geliştiriyor. " +
                    "Oyunda sana düşen görevse dünyadaki son şehri inşa edip halkının hayatta kalması için gerekli araçları güvence altına almak.",
                    GoruntulenmeSayisi = 585
                },              
                new Oyun()
                {
                    OyunID = 14,
                    Resim = "oyun14.jpg",
                    OyunAdi = "Euro Truck Simulator 2",
                    PiyasayaSurulmeTarihi = new DateTime(2012, 10, 18),
                    Yayinci = "SCS Software",
                    Gelistirici = "SCS Software",
                    Aciklama = "Euro Truck Simulator 2 bir tır simülasyon oyunudur. Oyun içerisinde verilen işlere göre tırları kullanıyorsunuz. " +
                    "Yük taşırken birçok yeri gezip görme fırsatınız da oluyor. Oyuna girdiğinizde bir hesap adınızı yazarak, ilgilendiğiniz bir markanın tırını seçip, uzun yol kaptanlığı maceranıza başlıyorsunuz. " +
                    "Oyunda seviye sistemi mevcut. Seviyeniz yükseldikçe puan kazanıyorsunuz. Puanları kullanmak için yetenek ağacı gibi bir sistem bulunuyor. " +
                    "Puanları hassas yük taşıma, tehlikeli madde taşıma, değerli yük taşıma gibi birçok alanda dağıtabiliyorsunuz. Euro Truck Simulator 2'de bir garajınız var. " +
                    "Seviyeniz yükseldikçe bu garajı da geliştirebiliyorsunuz. Oyunda iki farklı iş türü var. Diğer şirketlerden tek seferlik işleri alarak para kazanabilir ya da serbest çalışarak kendi aracınız ile şirketinize para kazandırabilirsiniz. " +
                    "Bir diğer özellik yeni bir araç aldığınızda aracınız için bir şoför kiralayabilir ve yetenekleri seçerek istediğiniz doğrultuda gelişmesini sağlayabilirsiniz.",
                    GoruntulenmeSayisi = 1301
                },
                new Oyun()
                {
                    OyunID = 15,
                    Resim = "oyun15.jpg",
                    OyunAdi = "F1 2020",
                    PiyasayaSurulmeTarihi = new DateTime(2020, 7, 9),
                    Yayinci = "Codemasters",
                    Gelistirici = "Codemasters",
                    Aciklama = "Şimdiye kadarki en kapsamlı F1 oyunu olan F1 2020 ile direksiyon başına geçip dünyanın en iyi sürücüleriyle yarışın. " +
                    "F1 2020 ile oyuncular ilk kez kendi F1 ekibini oluşturma imkanına kavuşuyor. Sürücü oluşturup, sponsor ve motor tedarikçisi seçip ekip arkadaşı tuttuktan sonra gruptaki 11. ekip olarak yarışabilirsiniz. " +
                    "Yeni tesisler oluşturun, zamanla ekibinizi geliştirin ve yarışlarda en tepeye oturun.",
                    GoruntulenmeSayisi = 702
                },
                new Oyun()
                {
                    OyunID = 16,
                    Resim = "oyun16.jpg",
                    OyunAdi = "FIFA 21",
                    PiyasayaSurulmeTarihi = new DateTime(2020, 10, 5),
                    Yayinci = "Electronic Arts",
                    Gelistirici = "Electronic Arts",
                    Aciklama = "FIFA 21, Electronic Arts tarafından geliştirilen ve aynı şirketinin yayımcılığını yaptığı spor simülasyon video oyunudur. " +
                    "Oyunda dünyanın dört bir yanından 17.000’den fazla futbolcu, 700’den fazla takım, 90’dan fazla stadyum ve 30’dan fazla lig bulunmaktadır. " +
                    "Volta football, Ultimate Team, kariyer modu gibi birçok mod vardır. ",
                    GoruntulenmeSayisi = 1487
                },
                new Oyun()
                {
                    OyunID = 17,
                    Resim = "oyun17.jpg",
                    OyunAdi = "NBA 2K21",
                    PiyasayaSurulmeTarihi = new DateTime(2020, 9, 4),
                    Yayinci = "2K",
                    Gelistirici = "Visual Concepts",
                    Aciklama = "NBA 2K21, dünyaca bilinen ve çok satan NBA 2K serisinin en yeni oyunudur. " +
                    "Sınıfının en iyisi oynanış, rekabetçi ve topluluk çevrimiçi özellikleri ve derin, çeşitli oyun modları üzerine yapılan heyecan verici geliştirmeler ile NBA 2K21, Everything is Game konsepti ile NBA basketbolu ve kültürünün tüm yönlerini benzersiz bir şekilde yaşamanızı sağlıyor.",
                    GoruntulenmeSayisi = 1006
                },
                new Oyun()
                {
                    OyunID = 18,
                    Resim = "oyun18.jpg",
                    OyunAdi = "eFootball PES 2021 SEASON UPDATE",
                    PiyasayaSurulmeTarihi = new DateTime(2020, 9, 15),
                    Yayinci = "Konami Digital Entertainment",
                    Gelistirici = "Konami Digital Entertainment",
                    Aciklama = "Bu ürün, bir futbol oyunu olan eFootball PES 2020'nin (2019 Eylül ayında yayınlanmıştı) güncellenmiş sürümüdür ve en yeni oyuncu verilerini ve kulüp kadrolarını içerir. " +
                    "Oyuncular eFootball PES 2020’de bulunan modları oynayabilmektedir.",
                    GoruntulenmeSayisi = 1369
                },
                new Oyun()
                {
                    OyunID = 19,
                    Resim = "oyun19.jpg",
                    OyunAdi = "Tekken 7",
                    PiyasayaSurulmeTarihi = new DateTime(2015, 3, 18),
                    Yayinci = "BANDAI NAMCO Entertainment",
                    Gelistirici = "BANDAI NAMCO Studios Inc.",
                    Aciklama = "Mishima klanının efsanevi yolculuğunun son bölümüne katıl, bitip tükenmek bilmeyen savaşlarının her bir aşamasının ardındaki gerçeği öğren. " +
                    "Gücünü Unreal Engine 4'ten alan TEKKEN 7, sahip olduğu yaratıcı dövüş mekanikleri sayesinde, muhteşem hikayelerle ilerleyen sinematik savaşların yanı sıra arkadaşlarınla ve rakiplerinle yapabileceğin müthiş düellolar da sunuyor.",
                    GoruntulenmeSayisi = 918
                },
                new Oyun()
                {
                    OyunID = 20,
                    Resim = "oyun20.jpg",
                    OyunAdi = "Forza Horizon 4",
                    PiyasayaSurulmeTarihi = new DateTime(2018, 10, 2),
                    Yayinci = "Microsoft Studios",
                    Gelistirici = "Playground Games",
                    Aciklama = "Oyun, Birleşik Krallık'ın kurgusal temsili bölgelerinde geçmektedir ve 450'den fazla lisanslı araç sunmaktadır. " +
                    "Oyun, oyuncuların kendi yarışlarını yaratmalarını sağlayan bir pist yaratıcısına sahiptir. Oyun, her sunucu 72 oyuncuya kadar desteklenerek, " +
                    "öncekilerden gelen AI güdümlü 'drivatarlara' kıyasla, senkronize paylaşılan bir dünyada geçmektedir ve seriye değişen mevsimleri tanıtmasıyla dikkat çekmektedir. " +
                    "Oyun, çevrimdışı modda da oynanabilmektedir. ",
                    GoruntulenmeSayisi = 1249
                },
                new Oyun()
                {
                    OyunID = 21,
                    Resim = "oyun21.jpg",
                    OyunAdi = "Dirt Rally 2.0",
                    PiyasayaSurulmeTarihi = new DateTime(2019, 2, 22),
                    Yayinci = "Code Masters",
                    Gelistirici = "Code Masters",
                    Aciklama = "DiRT Rally 2.0, en küçük hatanın yarışını sona erdirebileceğini bilerek, dünyanın dört bir yanından ikonik ralli konumları arasında en güçlü arazi araçlarıyla oynaman için sana meydan okuyor. " +
                    "Yeni özgün bir yol tutuşu modeli lastik seçimi ve yüzey deformasyonu dahil olmak üzere, en sürükleyici ve gerçekten odaklanmış arazi yarışı deneyimiyle içgüdülerine güvenmen gerekecek. " +
                    "Gerçek hayat arazi yarışı ortamları arasında sadece sana yol gösterecek yardımcı sürücün ve içgüdülerinle ralli aracını güçlendir. " +
                    "FIA World Rallycross şampiyonasının sekiz resmi turunda yarış, lisanslı Supercars ile tamamla ve serileri destekle. " +
                    "Takımını ve arabalarını yarış stratejilerinde geliştir ve hem tek oyuncu Kariyer Mücadelesi hem de rekabetçi bir çevrimiçi ortamda çeşitli Etkinlikler ve Şampiyonalar arasından ilerle.",
                    GoruntulenmeSayisi = 814
                },
                new Oyun()
                {
                    OyunID = 22,
                    Resim = "oyun22.jpg",
                    OyunAdi = "SpeedRunners",
                    PiyasayaSurulmeTarihi = new DateTime(2016, 4, 19),
                    Yayinci = "tinyBuild",
                    Gelistirici = "DoubleDutch Games",
                    Aciklama = "Oyun temel olarak oyuncuların bir platform üzerinde birbirleri ile yarışarak en son hayatta kalan yarışmacı olmalarını amaçlıyor. " +
                    "Oyunda birçok engel ve güçlendirme bulunmaktadır. Çok oyunculu modda kamera en öndeki oyuncuya odaklıdır.",
                    GoruntulenmeSayisi = 256
                },
                new Oyun()
                {
                    OyunID = 23,
                    Resim = "oyun23.jpg",
                    OyunAdi = "The Forest",
                    PiyasayaSurulmeTarihi = new DateTime(2018, 4, 30),
                    Yayinci = "Endnight Games Ltd",
                    Gelistirici = "Endnight Games Ltd",
                    Aciklama = "The Forest Endnight Games tarafından geliştirilen ve yayınlanan bir hayatta kalma video oyunudur. " +
                    "Oyun, ana karakter Eric Leblanc ve oğlu Timmy'nin uçak kazasıyla ormanlık bir yarımadaya düşmesini ve adadan kurtulma çabasını konu alıyor. " +
                    "Oyun, birinci şahıs perspektifinden oynanan açık bir dünya ortamında, belirli görevler veya görevler olmadan doğrusal bir oynanışa sahiptir ve oyuncuyu hayatta kalma kararlarını vermesi gerekmektedir.",
                    GoruntulenmeSayisi = 1503
                },
                new Oyun()
                {
                    OyunID = 24,
                    Resim = "oyun24.jpg",
                    OyunAdi = "Outlast",
                    PiyasayaSurulmeTarihi = new DateTime(2013, 9, 4),
                    Yayinci = "Red Barrels",
                    Gelistirici = "Red Barrels",
                    Aciklama = "Outlast, Red Barrels tarafından yapılmış ve yayınlanmış bir hayatta kalma-korku oyunudur. " +
                    "Oyunda Miles Upshur adındaki bir gazetecinin, garip olaylar olduğu konuşulan bir akıl hastanesini haber yapmak için el kamerası ile tek başına girdikten sonra yaşadığı olaylar oynanmaktadır.",
                    GoruntulenmeSayisi = 527
                },
                new Oyun()
                {
                    OyunID = 25,
                    Resim = "oyun25.jpg",
                    OyunAdi = "Outlast 2",
                    PiyasayaSurulmeTarihi = new DateTime(2017, 4, 25),
                    Yayinci = "Red Barrels",
                    Gelistirici = "Red Barrels",
                    Aciklama = "Outlast 2, ana karakter olan gazeteci Blake Langermann'ın, eşi Lynn ile beraber, Jane Doe ismindeki hamile bir kadının cinayetini araştırmak için gittikleri Arizona çöllerinde yaşadıklarını konu edinmektedir. " +
                    "Blake ve Lynn helikopterlerinin düşmesiyle birlikte ayrı düşecek, ve Blake de onu bulabilmek için, dünyanın son günlerini yaşadığına inanan aşırı dindar bir tarikatın hüküm sürdüğü Temple Gate kasabasında korkunç bir arayış içine girecektir.",
                    GoruntulenmeSayisi = 869
                },
                new Oyun()
                {
                    OyunID = 26,
                    Resim = "oyun26.jpg",
                    OyunAdi = "Phasmophobia",
                    PiyasayaSurulmeTarihi = new DateTime(2020, 9, 18),
                    Yayinci = "Kinetic Games",
                    Gelistirici = "Kinetic Games",
                    Aciklama = "Phasmophobia, hayaletler hakkında dedektiflik oyunudur. Oyunda siz ve arkadaşlarınızın bulunduğu 4 kişilik bir ekiple perili evlerden akıl hastanelerine birçok farklı konumda birçok farklı hikayeyi aydınlatmaya çalışıyorsunuz. " +
                    "Oyunda farklı özelliklere sahip hayaletler bulunuyor. Bu hayaletleri yakalamak için de farklı farklı yollar gerekiyor.",
                    GoruntulenmeSayisi = 1104
                },
                new Oyun()
                {
                    OyunID = 27,
                    Resim = "oyun27.jpg",
                    OyunAdi = "Green Hell",
                    PiyasayaSurulmeTarihi = new DateTime(2018, 8, 29),
                    Yayinci = "Creepy Jar",
                    Gelistirici = "Creepy Jar",
                    Aciklama = "Green Hell, balta girmemiş Amazon yağmur ormanlarında geçen açık dünyalı bir hayatta kalma oyunu. " +
                    "Yiyeceğin veya ekipmanın olmaksızın ormanda tek başına bırakılmanın ardından hayatta kalmaya ve buradan kurtulmaya çalışıyorsun. " +
                    "Hayata sıkı sıkı tutunmak için mücadele verdiğin bu dayanıklılık yolculuğunda, yalnızlığın etkileri hem bedenini hem de zihnini derinden etkiliyor. " +
                    "Bu yolculuk sırasında dış dünyadan herhangi bir yardım almayacaksın. Gerçek hayatta kalma teknikleri öğrenmenin ardından sadece ellerini kullanarak barınaklar inşa etmen, " +
                    "araçlar üretmen ve avlanıp kendini koruyabilmek için silahlar yapman gerekecek. Sürekli olarak ormanın tehdidi altında, vahşi hayvanlara ve tropik hastalıklara karşı savaşacaksın. " +
                    "Ayrıca kendi zihninin kurduğu tuzaklara ve uçsuz bucaksız ormanın karanlık köşelerinde gizlenen korkulara göğüs germek zorunda kalacaksın.",
                    GoruntulenmeSayisi = 986
                },
                new Oyun()
                {
                    OyunID = 28,
                    Resim = "oyun28.jpg",
                    OyunAdi = "Resident Evil 3",
                    PiyasayaSurulmeTarihi = new DateTime(2020, 4, 3),
                    Yayinci = "Capcom",
                    Gelistirici = "Capcom",
                    Aciklama = "Resident Evil 3, Capcom tarafından geliştirilen ve dağıtımı yapılan bir hayatta kalma-korku oyunudur. " +
                    "Jill Valentine, Umbrella'nın uyguladığı vahşete tanıklık eden Raccoon City'de kalan son insanlardan biridir. " +
                    "Umbrella onu durdurmak için büyük gizli silahı Nemesis'i kullanacaktır. 1999 yılında yayınlanan Resident Evil 3: Nemesis video oyunun yeniden yapılmış halidir.",
                    GoruntulenmeSayisi = 727
                }
            );
            modelBuilder.Entity<Kategori>().HasData(
                new Kategori()
                {
                    KategoriID = 1,
                    KategoriAdi = "Aksiyon",
                },
                new Kategori()
                {
                    KategoriID = 2,
                    KategoriAdi = "Korku",
                },
                new Kategori()
                {
                    KategoriID = 3,
                    KategoriAdi = "Spor/Yarış",
                },
                new Kategori()
                {
                    KategoriID = 4,
                    KategoriAdi = "Strateji",
                },
                new Kategori()
                {
                    KategoriID = 5,
                    KategoriAdi = "Simülasyon",
                },
                new Kategori()
                {
                    KategoriID = 6,
                    KategoriAdi = "Hayatta Kalma",
                },
                new Kategori()
                {
                    KategoriID = 7,
                    KategoriAdi = "Tek Oyunculu",
                },
                new Kategori()
                {
                    KategoriID = 8,
                    KategoriAdi = "Çok Oyunculu",
                }
            );
            modelBuilder.Entity<OyunKategorisi>().HasData(
                new OyunKategorisi()
                {
                    OyunID = 1,
                    KategoriID = 1
                },
                new OyunKategorisi()
                {
                    OyunID = 1,
                    KategoriID = 7
                },
                new OyunKategorisi()
                {
                    OyunID = 2,
                    KategoriID = 1
                },
                new OyunKategorisi()
                {
                    OyunID = 2,
                    KategoriID = 4
                },
                new OyunKategorisi()
                {
                    OyunID = 2,
                    KategoriID = 7
                },
                new OyunKategorisi()
                {
                    OyunID = 2,
                    KategoriID = 8
                },
                new OyunKategorisi()
                {
                    OyunID = 3,
                    KategoriID = 1
                },
                new OyunKategorisi()
                {
                    OyunID = 3,
                    KategoriID = 4
                },
                new OyunKategorisi()
                {
                    OyunID = 3,
                    KategoriID = 7
                },
                new OyunKategorisi()
                {
                    OyunID = 3,
                    KategoriID = 8
                },
                new OyunKategorisi()
                {
                    OyunID = 4,
                    KategoriID = 1
                },
                new OyunKategorisi()
                {
                    OyunID = 4,
                    KategoriID = 2
                },
                new OyunKategorisi()
                {
                    OyunID = 4,
                    KategoriID = 6
                },
                new OyunKategorisi()
                {
                    OyunID = 4,
                    KategoriID = 7
                },
                new OyunKategorisi()
                {
                    OyunID = 5,
                    KategoriID = 1
                },
                new OyunKategorisi()
                {
                    OyunID = 5,
                    KategoriID = 7
                },
                new OyunKategorisi()
                {
                    OyunID = 5,
                    KategoriID = 8
                },
                new OyunKategorisi()
                {
                    OyunID = 6,
                    KategoriID = 1
                },
                new OyunKategorisi()
                {
                    OyunID = 6,
                    KategoriID = 7
                },
                new OyunKategorisi()
                {
                    OyunID = 7,
                    KategoriID = 1
                },
                new OyunKategorisi()
                {
                    OyunID = 7,
                    KategoriID = 4
                },
                new OyunKategorisi()
                {
                    OyunID = 7,
                    KategoriID = 5
                },
                new OyunKategorisi()
                {
                    OyunID = 7,
                    KategoriID = 7
                },
                new OyunKategorisi()
                {
                    OyunID = 7,
                    KategoriID = 8
                },
                new OyunKategorisi()
                {
                   OyunID = 8,
                   KategoriID = 1
                 },
                new OyunKategorisi()
                {
                    OyunID = 8,
                    KategoriID = 4
                },
                new OyunKategorisi()
                {
                    OyunID = 8,
                    KategoriID = 5
                },
                new OyunKategorisi()
                {
                    OyunID = 8,
                    KategoriID = 7
                },
                new OyunKategorisi()
                {
                    OyunID = 8,
                    KategoriID = 8
                },
                new OyunKategorisi()
                {
                    OyunID = 9,
                    KategoriID = 3
                },
                new OyunKategorisi()
                {
                    OyunID = 9,
                    KategoriID = 4
                },
                new OyunKategorisi()
                {
                    OyunID = 9,
                    KategoriID = 5
                },
                new OyunKategorisi()
                {
                    OyunID = 9,
                    KategoriID = 7
                },
                new OyunKategorisi()
                {
                    OyunID = 9,
                    KategoriID = 8
                },
                new OyunKategorisi()
                {
                    OyunID = 10,
                    KategoriID = 4
                },
                new OyunKategorisi()
                {
                    OyunID = 10,
                    KategoriID = 5
                },
                new OyunKategorisi()
                {
                    OyunID = 10,
                    KategoriID = 7
                },             
                new OyunKategorisi()
                {
                    OyunID = 11,
                    KategoriID = 4
                },
                new OyunKategorisi()
                {
                    OyunID = 11,
                    KategoriID = 5
                },
                new OyunKategorisi()
                {
                    OyunID = 11,
                    KategoriID = 7
                },
                new OyunKategorisi()
                {
                    OyunID = 11,
                    KategoriID = 8
                },
                new OyunKategorisi()
                {
                    OyunID = 12,
                    KategoriID = 2
                },
                new OyunKategorisi()
                {
                    OyunID = 12,
                    KategoriID = 4
                },
                new OyunKategorisi()
                {
                    OyunID = 12,
                    KategoriID = 8
                },
                new OyunKategorisi()
                {
                    OyunID = 13,
                    KategoriID = 4
                },
                new OyunKategorisi()
                {
                    OyunID = 13,
                    KategoriID = 5
                },
                new OyunKategorisi()
                {
                    OyunID = 13,
                    KategoriID = 7
                },
                new OyunKategorisi()
                {
                    OyunID = 14,
                    KategoriID = 5
                },
                new OyunKategorisi()
                {
                    OyunID = 14,
                    KategoriID = 7
                },
                new OyunKategorisi()
                {
                    OyunID = 15,
                    KategoriID = 3
                },
                new OyunKategorisi()
                {
                    OyunID = 15,
                    KategoriID = 4
                },
                new OyunKategorisi()
                {
                    OyunID = 15,
                    KategoriID = 5
                },
                new OyunKategorisi()
                {
                    OyunID = 15,
                    KategoriID = 7
                },
                new OyunKategorisi()
                {
                    OyunID = 15,
                    KategoriID = 8
                },
                new OyunKategorisi()
                {
                    OyunID = 16,
                    KategoriID = 3
                },
                new OyunKategorisi()
                {
                    OyunID = 16,
                    KategoriID = 5
                },
                new OyunKategorisi()
                {
                    OyunID = 16,
                    KategoriID = 7
                },
                new OyunKategorisi()
                {
                    OyunID = 16,
                    KategoriID = 8
                },
                new OyunKategorisi()
                {
                    OyunID = 17,
                    KategoriID = 3
                },
                new OyunKategorisi()
                {
                    OyunID = 17,
                    KategoriID = 5
                },
                new OyunKategorisi()
                {
                    OyunID = 17,
                    KategoriID = 7
                },
                new OyunKategorisi()
                {
                    OyunID = 17,
                    KategoriID = 8
                },
                new OyunKategorisi()
                {
                    OyunID = 18,
                    KategoriID = 3
                },
                new OyunKategorisi()
                {
                    OyunID = 18,
                    KategoriID = 5
                },
                new OyunKategorisi()
                {
                    OyunID = 18,
                    KategoriID = 7
                },
                new OyunKategorisi()
                {
                    OyunID = 18,
                    KategoriID = 8
                },
                new OyunKategorisi()
                {
                    OyunID = 19,
                    KategoriID = 1
                },
                new OyunKategorisi()
                {
                    OyunID = 19,
                    KategoriID = 3
                },
                new OyunKategorisi()
                {
                    OyunID = 19,
                    KategoriID = 7
                },
                new OyunKategorisi()
                {
                    OyunID = 19,
                    KategoriID = 8
                },
                new OyunKategorisi()
                {
                    OyunID = 20,
                    KategoriID = 3
                },
                new OyunKategorisi()
                {
                    OyunID = 20,
                    KategoriID = 7
                },
                new OyunKategorisi()
                {
                    OyunID = 20,
                    KategoriID = 8
                },
                new OyunKategorisi()
                {
                    OyunID = 21,
                    KategoriID = 3
                },
                new OyunKategorisi()
                {
                    OyunID = 21,
                    KategoriID = 5
                },
                new OyunKategorisi()
                {
                    OyunID = 21,
                    KategoriID = 7
                },
                new OyunKategorisi()
                {
                    OyunID = 21,
                    KategoriID = 8
                },
                new OyunKategorisi()
                {
                    OyunID = 22,
                    KategoriID = 1
                },
                new OyunKategorisi()
                {
                    OyunID = 22,
                    KategoriID = 3
                },
                new OyunKategorisi()
                {
                    OyunID = 22,
                    KategoriID = 7
                },
                new OyunKategorisi()
                {
                    OyunID = 22,
                    KategoriID = 8
                },
                new OyunKategorisi()
                {
                    OyunID = 23,
                    KategoriID = 1
                },
                new OyunKategorisi()
                {
                    OyunID = 23,
                    KategoriID = 2
                },
                new OyunKategorisi()
                {
                    OyunID = 23,
                    KategoriID = 5
                },
                new OyunKategorisi()
                {
                    OyunID = 23,
                    KategoriID = 6
                },
                new OyunKategorisi()
                {
                    OyunID = 23,
                    KategoriID = 7
                },
                new OyunKategorisi()
                {
                    OyunID = 23,
                    KategoriID = 8
                },
                new OyunKategorisi()
                {
                    OyunID = 24,
                    KategoriID = 1
                },
                new OyunKategorisi()
                {
                    OyunID = 24,
                    KategoriID = 2
                },
                new OyunKategorisi()
                {
                    OyunID = 24,
                    KategoriID = 6
                },
                new OyunKategorisi()
                {
                    OyunID = 24,
                    KategoriID = 7
                },
                new OyunKategorisi()
                {
                    OyunID = 25,
                    KategoriID = 1
                },
                new OyunKategorisi()
                {
                    OyunID = 25,
                    KategoriID = 2
                },
                new OyunKategorisi()
                {
                    OyunID = 25,
                    KategoriID = 6
                },
                new OyunKategorisi()
                {
                    OyunID = 25,
                    KategoriID = 7
                },
                new OyunKategorisi()
                {
                    OyunID = 26,
                    KategoriID = 1
                },
                new OyunKategorisi()
                {
                    OyunID = 26,
                    KategoriID = 2
                },
                new OyunKategorisi()
                {
                    OyunID = 26,
                    KategoriID = 8
                },
                new OyunKategorisi()
                {
                    OyunID = 27,
                    KategoriID = 2
                },
                new OyunKategorisi()
                {
                    OyunID = 27,
                    KategoriID = 5
                },
                new OyunKategorisi()
                {
                    OyunID = 27,
                    KategoriID = 6
                },
                new OyunKategorisi()
                {
                    OyunID = 27,
                    KategoriID = 7
                },
                new OyunKategorisi()
                {
                    OyunID = 27,
                    KategoriID = 8
                },
                new OyunKategorisi()
                {
                    OyunID = 28,
                    KategoriID = 1
                },
                new OyunKategorisi()
                {
                    OyunID = 28,
                    KategoriID = 2
                },
                new OyunKategorisi()
                {
                    OyunID = 28,
                    KategoriID = 6
                },
                new OyunKategorisi()
                {
                    OyunID = 28,
                    KategoriID = 7
                },
                new OyunKategorisi()
                {
                    OyunID = 28,
                    KategoriID = 8
                }
            );
        }
    }
}