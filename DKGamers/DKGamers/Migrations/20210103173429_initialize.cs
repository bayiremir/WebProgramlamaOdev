using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DKGamers.Migrations
{
    public partial class initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Haber",
                columns: table => new
                {
                    HaberID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HaberResim = table.Column<string>(nullable: false),
                    HaberBaslik = table.Column<string>(nullable: false),
                    HaberIcerik = table.Column<string>(nullable: false),
                    haberGosterilsinmi = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haber", x => x.HaberID);
                });

            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    KategoriID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "Oyun",
                columns: table => new
                {
                    OyunID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Resim = table.Column<string>(nullable: false),
                    OyunAdi = table.Column<string>(nullable: false),
                    PiyasayaSurulmeTarihi = table.Column<DateTime>(nullable: false),
                    Yayinci = table.Column<string>(nullable: false),
                    Gelistirici = table.Column<string>(nullable: false),
                    Aciklama = table.Column<string>(nullable: false),
                    GoruntulenmeSayisi = table.Column<int>(nullable: false),
                    oyunGosterilsinmi = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oyun", x => x.OyunID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favori",
                columns: table => new
                {
                    FavoriID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(nullable: true),
                    OyunID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favori", x => x.FavoriID);
                    table.ForeignKey(
                        name: "FK_Favori_Oyun_OyunID",
                        column: x => x.OyunID,
                        principalTable: "Oyun",
                        principalColumn: "OyunID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OyunKategorisi",
                columns: table => new
                {
                    OyunID = table.Column<int>(nullable: false),
                    KategoriID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OyunKategorisi", x => new { x.OyunID, x.KategoriID });
                    table.ForeignKey(
                        name: "FK_OyunKategorisi_Kategori_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategori",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OyunKategorisi_Oyun_OyunID",
                        column: x => x.OyunID,
                        principalTable: "Oyun",
                        principalColumn: "OyunID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yorum",
                columns: table => new
                {
                    YorumID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YapilanYorum = table.Column<string>(nullable: true),
                    OlusturulmaTarihi = table.Column<DateTime>(nullable: false),
                    OyunID = table.Column<int>(nullable: false),
                    KullaniciAdi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorum", x => x.YorumID);
                    table.ForeignKey(
                        name: "FK_Yorum_Oyun_OyunID",
                        column: x => x.OyunID,
                        principalTable: "Oyun",
                        principalColumn: "OyunID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2", "80a65347-4a6e-4703-a9d2-baef8a137b60", "user", "USER" },
                    { "1", "74b093fb-ee7c-45a0-91e7-962b9fe86656", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e317364-e21d-5613-a6d7-9413e041cdb9", 0, "9e5fc502-894b-4c03-b837-7c0eeb897337", "berk77@outlook.com", true, false, null, "BERK77@OUTLOOK.COM", "BERK77", "AQAAAAEAACcQAAAAEKubhPYY28YrDpBDMADc2RcqE/xfAP8kFPC0bSA0usCykRTO62a36NnHITko7HsOQw==", null, false, "c44d5e53-aac6-493f-85b9-e5e87a90a6eb", false, "berk77" },
                    { "8e117364-e21d-4613-a6d7-9423e041cdb9", 0, "54bb3558-31f9-4975-b656-534dee245cca", "b181210057@sakarya.edu.tr", true, false, null, "B181210057@SAKARYA.EDU.TR", "B181210057@SAKARYA.EDU.TR", "AQAAAAEAACcQAAAAENi3uklsXLw+2ndNW8cqo+PeDED7DriN9GEtg4vAB9Z+JSZRDx+zzy5n4OV4hcim3A==", null, false, "6ca6d02d-c943-4f37-a532-ba61a7b309c6", false, "b181210057@sakarya.edu.tr" },
                    { "8e117364-e21d-5613-a6d7-9413e041cdb9", 0, "fc7876bc-4f30-4a7b-a6bf-0378da767667", "bayram@outlook.com", true, false, null, "BAYRAM@OUTLOOK.COM", "BAYRAM57", "AQAAAAEAACcQAAAAELkxaEUNoKznB63MC0T06YfS/9guVH6KpXL8Epre+EOJXwLAMn6tdcSHNAF263N5KA==", null, false, "6fe8b204-23f1-486a-952c-18db006c2cfb", false, "bayram57" },
                    { "8e117364-e21d-4713-a6d7-9423d041edb9", 0, "66cf4266-3c89-456e-af80-6a43ccd12ea0", "b181210051@sakarya.edu.tr", true, false, null, "B181210051@SAKARYA.EDU.TR", "B181210051@SAKARYA.EDU.TR", "AQAAAAEAACcQAAAAEM2OB3RLcIzRJ6x6pqSZNjnP6mJcghFosb/IBPd5zrH099ogMq4ltPLWkLsvwYPXyQ==", null, false, "bcd7d032-8c9d-493e-9691-888cbf4ea8d1", false, "b181210051@sakarya.edu.tr" },
                    { "8e217364-e21d-5613-a6d7-9413e041cdb9", 0, "5887d29c-8fda-4914-b472-923ccafdc8e8", "batuhan34@outlook.com", true, false, null, "BATUHAN34@OUTLOOK.COM", "BATUHAN34", "AQAAAAEAACcQAAAAEBMwI6ZQ1NNZ2TZvqXqSIeWxC6ZNHUe65+hCCoGTeH/fvlsi2ZfRfSb80MRGCwdIBA==", null, false, "1fb3e6ef-d28a-4f21-b352-1e0143928a0a", false, "batuhan34" }
                });

            migrationBuilder.InsertData(
                table: "Haber",
                columns: new[] { "HaberID", "HaberBaslik", "HaberIcerik", "HaberResim", "haberGosterilsinmi" },
                values: new object[,]
                {
                    { 3, "The Forest'ın Devam Oyunu Sons Of The Forest İçin Yeni Fragman Yayınlandı", "Macera türündeki Sons Of The Forest oyunu için dikkat çekici yeni bir oynanış videosu daha yayınlandı. Hatırı sayılır bir hayran kitlesine sahip olan The Forest oyununun devamı niteliğinde karşımıza çıkacak olan Sons Of The Forest, hem görsel yöndeki gelişimi hem de oynanış dinamikleri ile türü seven oyuncuları yine memnun edeceğe benziyor. Endnight Games ekibi tarafından geliştirilen Sons Of The Forest, 2021 yılında çıkacak.Net bir çıkış tarihi belli olmayan oyun Unity grafik motoru kullanılarak geliştiriliyor.Görsel olarak oldukça hoş gözüken oyunun yapım ekibi hem işleme hem de ışıklandırma gibi noktalarda önemli geliştirmeler yapıldığını belirtmiş.Bu sayede oyunun değişken hava şartlarının çok daha iyi gözükeceği gelen bilgiler arasında. Zaten yayınlanan oynanış videosuna baktığımızda da karlı alanların ve değişen hava şartlarının gerçekten de güzel gözüktüğünü fark ediyoruz. İlk oyunda olduğu gibi inşa etme dinamiklerinin oldukça önemli olduğu Sons Of The Forest oyununda yeni inşa seçenekleri ve düşman çeşitleri de bulunacak. Oyunda yakın dövüş dinamiklerine daha fazla ağırlık verilecek.", "haber3.jpg", false },
                    { 2, "Steam'de Anlık Oyuncu Sayısında Rekor Kırıldı", "Koronavirüsün de etkisiyle hafta sonunu evde geçiren milyonlarca oyun sever, Steam’e akın etti. Ünlü oyun platformunda 24 milyon 804 bin 148 kullanıcı aynı anda aktif oldu. 25 milyona yakın kullanıcının Steam’de aktif olmasında en büyük etkenlerinden biri, uygulamanın bilgisayar açılınca otomatik aktif olması. Ancak Steam, anlık oyuncu sayısında da 7 milyonu görerek kendi rekorunu bir kez daha kırdı. 25 milyon kullanıcı içinde Steam’de oyun oynayan 7 milyon kişinin oynadıkları oyunların başında Counter-Strike: Global Offensive(1.062.017 kullanıcı), Cyberpunk 2077(1.047.602 kullanıcı) ve Playerunknown’s Battlegrounds(648.889 kullanıcı) bulunuyor. Tek oyunculu bir oyun olmasına rağmen neredeyse CS:GO ile aynı oyuncu sayısına erişen Cyberpunk 2077 ise anlık olarak 654.963 oyuncu sayısına ulaştı.Steam’in bundan önceki rekoru koronavirüsün dünya çapında yayılmaya başladığı aylarda gelmişti.Mart 2020‘de 22 milyon anlık kullanıcıya erişen Steam, üst üste 3 defa rekor kırmıştı.", "haber4.jpg", false },
                    { 1, "The Game Awards 2020 Kazananları Açıklandı", "Dünyanın en büyük video oyun ödül organizasyonlarından bir tanesi olan The Game Awards 2020 etkinlikleri, Türkiye saati ile gece 03:00 sularında gerçekleşti. 2020'nin en'lerinin seçildiği seçildiği etkinlikler kapsamında da herkesin tahmin edebileceği bazı oyunlar, çeşitli ödüllere layık görüldü.İşte The Game Awards 2020'nin tüm kazananları:Yılın Oyunu: The Last of Us: Part II Oyuncunun Sesi: Ghost of Tsushima En İyi Oyun Yönetmenliği: The Last of Us: Part II En İyi Anlatı: The Last of Us: Part II En İyi Sanat Yönetmenliği: Ghost of Tsushima En İyi Ses Tasarımı: The Last of Us: Part II En İyi Müzik: Final Fantasy VII RemakeKarakterler Bazında En İyi Performans: The Last of Us: Part II En Çok Etkileyen Oyun: Tell Me Why Devam Etmekte Olan En İyi Oyun: No Man's Sky En İyi Indie Oyun: Hades En İyi Mobil Oyun: Among Us En İyi Topluluk Desteği Veren Oyun: Fall Guys: Ultimate Knockout En İyi Sanal Gerçeklik/Artırılmış Gerçeklik Oyunu: Half - Life: Alyx En İyi Erişilebilirlikte Yenilik Oyunu: The Last of Us: Part II En İyi Aksiyon Oyunu: Hades En İyi Aksiyon/Macera Oyunu: The Last of Us: Part II En İyi RPG Oyunu: Final Fantasy VII Remake En İyi Dövüş Oyunu: Mortal Kombat 11 Ultimate En İyi Aile Oyunu: Animal Crossing: New Horizons En İyi Simülasyon/Strateji Oyunu: Microsoft Flight Simulator En İyi Spor/Yarış Oyunu: Tony Hawk’s Pro Skater 1 + 2 En İyi Çok Oyunculu Oyun: Among Us En Çok Beklenen Oyun: Elden Ring En İyi İçerik Üreticisi: Valkyrae En İyi Çıkış Yapan Oyun: Phasmophobia En İyi E-spor Oyunu: League of Legends En İyi E-spor Takımı: G2 EsportsEn İyi E-spor Etkinliği: League of Legends", "haber5.jpg", false },
                    { 4, "CD PROJEKT RED'e Cyberpunk 2077 Yüzünden İlk Dava Açıldı", "Video oyun sektörünün son dönemlerdeki en çok tartışılan ismi, CD PROJEKT RED. Bunun nedeniyse, kısa bir süre önce piyasaya sürülen Cyberpunk 2077. Oyunda yaşanan sorunlar, şirketin oldukça ağır bir şekilde eleştirilmesine yol açtı. Ancak şirket, sadece eleştirileri yutmak zorunda kalmayacak. Çünkü Rosen Law isimli bir şirket, CD PROJEKT RED'den davacı oldu. Rosen Law isimli hukuk şirketi tarafından açılan davaya göre CD PROJEKT RED, Cyberpunk 2077'yi piyasaya sürmeden önce, oyuncuları ve yatırımcıları yanlış yönlendirdi. Şirket aslında, oyunun ne halde olduğunu biliyordu ancak bunu gizledi. Bu sayede de Cyberpunk 2077'nin hype'lanmaya devam etmesine neden olan CD PROJEKT RED, bir nevi haksız kazanç elde etmiş oldu. Rosen Law tarafından açılan davanın şu an için bilindik bir katılımcısı yok. Ancak şirket, özellikle de yatırımcıların bu davaya dahil olmaları gerektiğini, hisse senedi değerlerinin ortada olduğunu ifade ediyor. Ayrıca dileyen oyuncuların da davaya dahil olabileceğini söyleyen hukuk şirketi, davaya dahil olmak isteyenlere de bir çevrimiçi form sunuyor. Yaşanan olay, CD PROJEKT RED için bir ilk niteliğinde. Ancak bu durum, son olmayabilir. Çünkü geliştirici şirketin ana vatanı olan Polonya'da da yatırımcılar, şirkete karşı yaptırım planları üzerinde yoğunlaşmış durumdalar. Tüm bu olayların nasıl sonuçlanacağı bilinmiyor ancak CD PROJEKT RED'i oldukça zorlu günlerin beklediğini şimdiden söyleyebiliriz.", "haber2.jpg", false },
                    { 5, "Steam, 2020'nin En Çok Satan Oyunlarını Açıkladı", "Dünyanın en büyük dijital oyun mağazası olan Steam, 2020'nin en iyileri listesini yayınladı. Listeye göre brüt gelirler ölçülen 2020'nin en çok satan 12 Steam oyunu;– Dota 2,- Grand Theft Auto V,– Red Dead Redemption 2,– Cyberpunk 2077,– Playerunknown’s Battlegrounds,– Doom Eternal,– Monster Hunter World,- Rainbow Six: Siege,– Destiny 2,– Fall Guys: Ultimate Knockout,– Counter - Strike: Global Offensive ve – Among Us oldu.Listeye göre 2020'nin en çok oynanılan oyunlarıysa;– Dota 2,– Among Us,– Terraria,– Cyberpunk 2077,– Life is Strange 2,– Monster Hunter World,– Counter - Strike: Global Offensive,– Mount & Blade 2: Bannerlord,– Destiny 2,– Playerunknown’s Battlegrounds ve – Grand Theft Auto V oldu.", "haber1.jpg", false }
                });

            migrationBuilder.InsertData(
                table: "Kategori",
                columns: new[] { "KategoriID", "KategoriAdi" },
                values: new object[,]
                {
                    { 8, "Çok Oyunculu" },
                    { 7, "Tek Oyunculu" },
                    { 6, "Hayatta Kalma" },
                    { 3, "Spor/Yarış" },
                    { 2, "Korku" },
                    { 1, "Aksiyon" },
                    { 4, "Strateji" },
                    { 5, "Simülasyon" }
                });

            migrationBuilder.InsertData(
                table: "Oyun",
                columns: new[] { "OyunID", "Aciklama", "Gelistirici", "GoruntulenmeSayisi", "OyunAdi", "PiyasayaSurulmeTarihi", "Resim", "Yayinci", "oyunGosterilsinmi" },
                values: new object[,]
                {
                    { 18, "Bu ürün, bir futbol oyunu olan eFootball PES 2020'nin (2019 Eylül ayında yayınlanmıştı) güncellenmiş sürümüdür ve en yeni oyuncu verilerini ve kulüp kadrolarını içerir. Oyuncular eFootball PES 2020’de bulunan modları oynayabilmektedir.", "Konami Digital Entertainment", 1369, "eFootball PES 2021 SEASON UPDATE", new DateTime(2020, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun18.jpg", "Konami Digital Entertainment", false },
                    { 19, "Mishima klanının efsanevi yolculuğunun son bölümüne katıl, bitip tükenmek bilmeyen savaşlarının her bir aşamasının ardındaki gerçeği öğren. Gücünü Unreal Engine 4'ten alan TEKKEN 7, sahip olduğu yaratıcı dövüş mekanikleri sayesinde, muhteşem hikayelerle ilerleyen sinematik savaşların yanı sıra arkadaşlarınla ve rakiplerinle yapabileceğin müthiş düellolar da sunuyor.", "BANDAI NAMCO Studios Inc.", 918, "Tekken 7", new DateTime(2015, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun19.jpg", "BANDAI NAMCO Entertainment", false },
                    { 20, "Oyun, Birleşik Krallık'ın kurgusal temsili bölgelerinde geçmektedir ve 450'den fazla lisanslı araç sunmaktadır. Oyun, oyuncuların kendi yarışlarını yaratmalarını sağlayan bir pist yaratıcısına sahiptir. Oyun, her sunucu 72 oyuncuya kadar desteklenerek, öncekilerden gelen AI güdümlü 'drivatarlara' kıyasla, senkronize paylaşılan bir dünyada geçmektedir ve seriye değişen mevsimleri tanıtmasıyla dikkat çekmektedir. Oyun, çevrimdışı modda da oynanabilmektedir. ", "Playground Games", 1249, "Forza Horizon 4", new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun20.jpg", "Microsoft Studios", false },
                    { 21, "DiRT Rally 2.0, en küçük hatanın yarışını sona erdirebileceğini bilerek, dünyanın dört bir yanından ikonik ralli konumları arasında en güçlü arazi araçlarıyla oynaman için sana meydan okuyor. Yeni özgün bir yol tutuşu modeli lastik seçimi ve yüzey deformasyonu dahil olmak üzere, en sürükleyici ve gerçekten odaklanmış arazi yarışı deneyimiyle içgüdülerine güvenmen gerekecek. Gerçek hayat arazi yarışı ortamları arasında sadece sana yol gösterecek yardımcı sürücün ve içgüdülerinle ralli aracını güçlendir. FIA World Rallycross şampiyonasının sekiz resmi turunda yarış, lisanslı Supercars ile tamamla ve serileri destekle. Takımını ve arabalarını yarış stratejilerinde geliştir ve hem tek oyuncu Kariyer Mücadelesi hem de rekabetçi bir çevrimiçi ortamda çeşitli Etkinlikler ve Şampiyonalar arasından ilerle.", "Code Masters", 814, "Dirt Rally 2.0", new DateTime(2019, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun21.jpg", "Code Masters", false },
                    { 22, "Oyun temel olarak oyuncuların bir platform üzerinde birbirleri ile yarışarak en son hayatta kalan yarışmacı olmalarını amaçlıyor. Oyunda birçok engel ve güçlendirme bulunmaktadır. Çok oyunculu modda kamera en öndeki oyuncuya odaklıdır.", "DoubleDutch Games", 256, "SpeedRunners", new DateTime(2016, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun22.jpg", "tinyBuild", false },
                    { 28, "Resident Evil 3, Capcom tarafından geliştirilen ve dağıtımı yapılan bir hayatta kalma-korku oyunudur. Jill Valentine, Umbrella'nın uyguladığı vahşete tanıklık eden Raccoon City'de kalan son insanlardan biridir. Umbrella onu durdurmak için büyük gizli silahı Nemesis'i kullanacaktır. 1999 yılında yayınlanan Resident Evil 3: Nemesis video oyunun yeniden yapılmış halidir.", "Capcom", 727, "Resident Evil 3", new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun28.jpg", "Capcom", false },
                    { 24, "Outlast, Red Barrels tarafından yapılmış ve yayınlanmış bir hayatta kalma-korku oyunudur. Oyunda Miles Upshur adındaki bir gazetecinin, garip olaylar olduğu konuşulan bir akıl hastanesini haber yapmak için el kamerası ile tek başına girdikten sonra yaşadığı olaylar oynanmaktadır.", "Red Barrels", 527, "Outlast", new DateTime(2013, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun24.jpg", "Red Barrels", false },
                    { 25, "Outlast 2, ana karakter olan gazeteci Blake Langermann'ın, eşi Lynn ile beraber, Jane Doe ismindeki hamile bir kadının cinayetini araştırmak için gittikleri Arizona çöllerinde yaşadıklarını konu edinmektedir. Blake ve Lynn helikopterlerinin düşmesiyle birlikte ayrı düşecek, ve Blake de onu bulabilmek için, dünyanın son günlerini yaşadığına inanan aşırı dindar bir tarikatın hüküm sürdüğü Temple Gate kasabasında korkunç bir arayış içine girecektir.", "Red Barrels", 869, "Outlast 2", new DateTime(2017, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun25.jpg", "Red Barrels", false },
                    { 26, "Phasmophobia, hayaletler hakkında dedektiflik oyunudur. Oyunda siz ve arkadaşlarınızın bulunduğu 4 kişilik bir ekiple perili evlerden akıl hastanelerine birçok farklı konumda birçok farklı hikayeyi aydınlatmaya çalışıyorsunuz. Oyunda farklı özelliklere sahip hayaletler bulunuyor. Bu hayaletleri yakalamak için de farklı farklı yollar gerekiyor.", "Kinetic Games", 1104, "Phasmophobia", new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun26.jpg", "Kinetic Games", false },
                    { 27, "Green Hell, balta girmemiş Amazon yağmur ormanlarında geçen açık dünyalı bir hayatta kalma oyunu. Yiyeceğin veya ekipmanın olmaksızın ormanda tek başına bırakılmanın ardından hayatta kalmaya ve buradan kurtulmaya çalışıyorsun. Hayata sıkı sıkı tutunmak için mücadele verdiğin bu dayanıklılık yolculuğunda, yalnızlığın etkileri hem bedenini hem de zihnini derinden etkiliyor. Bu yolculuk sırasında dış dünyadan herhangi bir yardım almayacaksın. Gerçek hayatta kalma teknikleri öğrenmenin ardından sadece ellerini kullanarak barınaklar inşa etmen, araçlar üretmen ve avlanıp kendini koruyabilmek için silahlar yapman gerekecek. Sürekli olarak ormanın tehdidi altında, vahşi hayvanlara ve tropik hastalıklara karşı savaşacaksın. Ayrıca kendi zihninin kurduğu tuzaklara ve uçsuz bucaksız ormanın karanlık köşelerinde gizlenen korkulara göğüs germek zorunda kalacaksın.", "Creepy Jar", 986, "Green Hell", new DateTime(2018, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun27.jpg", "Creepy Jar", false },
                    { 17, "NBA 2K21, dünyaca bilinen ve çok satan NBA 2K serisinin en yeni oyunudur. Sınıfının en iyisi oynanış, rekabetçi ve topluluk çevrimiçi özellikleri ve derin, çeşitli oyun modları üzerine yapılan heyecan verici geliştirmeler ile NBA 2K21, Everything is Game konsepti ile NBA basketbolu ve kültürünün tüm yönlerini benzersiz bir şekilde yaşamanızı sağlıyor.", "Visual Concepts", 1006, "NBA 2K21", new DateTime(2020, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun17.jpg", "2K", false },
                    { 23, "The Forest Endnight Games tarafından geliştirilen ve yayınlanan bir hayatta kalma video oyunudur. Oyun, ana karakter Eric Leblanc ve oğlu Timmy'nin uçak kazasıyla ormanlık bir yarımadaya düşmesini ve adadan kurtulma çabasını konu alıyor. Oyun, birinci şahıs perspektifinden oynanan açık bir dünya ortamında, belirli görevler veya görevler olmadan doğrusal bir oynanışa sahiptir ve oyuncuyu hayatta kalma kararlarını vermesi gerekmektedir.", "Endnight Games Ltd", 1503, "The Forest", new DateTime(2018, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun23.jpg", "Endnight Games Ltd", false },
                    { 16, "FIFA 21, Electronic Arts tarafından geliştirilen ve aynı şirketinin yayımcılığını yaptığı spor simülasyon video oyunudur. Oyunda dünyanın dört bir yanından 17.000’den fazla futbolcu, 700’den fazla takım, 90’dan fazla stadyum ve 30’dan fazla lig bulunmaktadır. Volta football, Ultimate Team, kariyer modu gibi birçok mod vardır. ", "Electronic Arts", 1487, "FIFA 21", new DateTime(2020, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun16.jpg", "Electronic Arts", false },
                    { 8, "Mount & Blade II: Bannerlord, orta çağ savaş simülasyon ve rol-yapma oyunu olan Mount & Blade: Warband’in heyecanla beklenen devamı niteliğindedir. 200 yıl öncesinde geçen, detaylı dövüş sistemini ve Kalradya dünyasını daha kapsamlı ele alır. Dağlardaki sığınakları talan edin, şehirlerin arka sokaklarında gizli suç imparatorlukları kurun ya da güç mücadelenizde savaş keşmekeşinin içine atılın. Engin Kalradya kıtasında keşfe çıkın, baskınlar düzenleyin ve yolunuz boyunca dostlar düşmanlar edinin. Kendi ordunuzu yetiştirip savaşa sokun; bir yandan birliklerinizi komuta ederken diğer yandan onların yanında aksiyonun kalbine dalıp düşmanla çarpışın.", "TaleWorlds Entertainment", 1453, "Mount & Blade II: Bannerlord", new DateTime(2020, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun8.jpg", "TaleWorlds Entertainment", false },
                    { 14, "Euro Truck Simulator 2 bir tır simülasyon oyunudur. Oyun içerisinde verilen işlere göre tırları kullanıyorsunuz. Yük taşırken birçok yeri gezip görme fırsatınız da oluyor. Oyuna girdiğinizde bir hesap adınızı yazarak, ilgilendiğiniz bir markanın tırını seçip, uzun yol kaptanlığı maceranıza başlıyorsunuz. Oyunda seviye sistemi mevcut. Seviyeniz yükseldikçe puan kazanıyorsunuz. Puanları kullanmak için yetenek ağacı gibi bir sistem bulunuyor. Puanları hassas yük taşıma, tehlikeli madde taşıma, değerli yük taşıma gibi birçok alanda dağıtabiliyorsunuz. Euro Truck Simulator 2'de bir garajınız var. Seviyeniz yükseldikçe bu garajı da geliştirebiliyorsunuz. Oyunda iki farklı iş türü var. Diğer şirketlerden tek seferlik işleri alarak para kazanabilir ya da serbest çalışarak kendi aracınız ile şirketinize para kazandırabilirsiniz. Bir diğer özellik yeni bir araç aldığınızda aracınız için bir şoför kiralayabilir ve yetenekleri seçerek istediğiniz doğrultuda gelişmesini sağlayabilirsiniz.", "SCS Software", 1301, "Euro Truck Simulator 2", new DateTime(2012, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun14.jpg", "SCS Software", false },
                    { 13, "Frostpunk, ısının yaşam anlamına geldiği ve her kararın bir bedelinin olduğu bir toplum olarak hayatta kalma oyunu. Tamamen donmuş bir dünyada, insanlar karşı konulamaz soğukla başa çıkabilmek için buhar gücü teknolojisini geliştiriyor. Oyunda sana düşen görevse dünyadaki son şehri inşa edip halkının hayatta kalması için gerekli araçları güvence altına almak.", "11 Bit Studios", 585, "Frostpunk", new DateTime(2018, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun13.jpg", "11 Bit Studios", false },
                    { 12, "Dead by Daylight, çok heyecanlı ve oldukça rekabetçi, korku ve gerilim ögelerine sahip bir hayatta kalma ve gizlilik oyunudur. Oyunda bir kişi katil, dört kişi ise katilden kaçmaya çalışan kişileri oluşturuyor. Burada amaç, katilden kaçarak hayatta kalmak. Oyunda dilerseniz hayatta kalmaya çalışan birini oynayabilir, dilerseniz de onları öldürmeye çalışan katili oynayabilirsiniz. Oyunda katil olmak veya hayatta kalmaya çalışmanın yanı sıra, arkadaşlarınızla hayatta kalma modu sayesinde rastgele bir katil oyuncu ile karşılaşıp arkadaşlarınızla beraber hayatta kalmaya çalışabilirsiniz. Arkadaşlarını öldür modunda ise sadece arkadaşlarınızla karşılaşırsınız, ancak bu modda seviye kazanılmaz.", "Behaviour Interactive Inc.", 952, "Dead by Daylight", new DateTime(2016, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun12.jpg", "Behaviour Interactive Inc.", false },
                    { 11, "Oyun, önceki oyunları Crusader Kings ve Crusader Kings II gibi, Orta Çağ'da geçen bir strateji ve hanedan simülasyonu oyunudur. Viking Çağı'ndan Bizans'ın Düşüşüne kadar devam etmektedir. Karakterler, 2D portreler yerine tam gövdeli, 3D olarak oluşturulmuş karakter modellerine sahiptir. Crusader Kings II'de olduğu gibi, istatistiklerini ve davranışlarını etkileyen özelliklere sahiptirler. Bir karakterin özelliklerine aykırı seçimler yapmak, o karakterin stresini artıracaktır. Oyunun genetik sistemi, karakterlerin bazı özelliklerini torunlarına aktarmalarına izin veriyor. Karakterler takip etmek için beş yaşam tarzından birini seçebilirler. Her yaşam tarzının, karakterlerin o yaşam tarzıyla ilgili becerileri geliştirmesine izin veren üç beceri ağacı vardır. ", "Paradox Development Studio", 1089, "Crusader Kings III", new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun11.jpg", "Paradox Interactive", false },
                    { 10, "Oyunda oyuncular 1982'nin sonlarında, Arstotzka isimli komünist bir ülkedeki bir vize memurunu yönetmektedir. Oyuncuların oyunda yaptıkları tek şey gelen insanları ülkeye almak ya da almamak. Oyuncular ülkeye birisini alırken çok dikkatli olmalıdır. Çünkü aldıkları kişi bir casus, bir terörist olabilir. Oyuncular gün sonunda yaptıkları işlem sayısına göre para kazanmaktadır. Kazandıkları bu parayla da ailelerine bakmaya çalışırlar.", "Lucas Pope", 293, "Papers, Please", new DateTime(2013, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun10.jpg", "3909", false },
                    { 9, "Bir menajerlik oyunudur. Oyuncular istedikleri takımı alır ve yönetir. Oyunun amacı, seçtiğin takımı dünyanın en iyi takımı yapmak ve şampiyonluklar yaşamaktır. Oyuncular altyapıdan oyuncu yetiştirme, takım taktiğini belirleme, oyuncu transfer etme gibi işlemleri yapabilir.", "Sports Interactive", 853, "Football Manager 2021", new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun9.jpg", "SEGA", false },
                    { 7, "Hearts of Iron IV Paradox Development Studio tarafından geliştirilen ve Paradox Interactive tarafından yayımlanan strateji oyunudur. Hearts of Iron III'ün devam oyunudur, diğer Hearts of Iron serisi oyunları gibi II. Dünya Savaşına odaklanır. Oyuncular 1936 ve 1939 olmak üzere iki başlangıç tarihinden birini seçebilir. Daha sonra oyuncular oyuna başlamak için ülke seçer. Oyuncuların amacı seçtikleri ülkeyle savaşta zafer almaya çalışmaktır. Bu amaca ulaşmak için oyuncuların ülkelerini doğru yönetmesi ve geliştirmesi gerekmektedir. ", "Paradox Development Studio", 1267, "Hearts of Iron IV", new DateTime(2016, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun7.jpg", "Paradox Interactive", false },
                    { 5, "Sea of Thieves, birinci şahıs bakış açısıyla oynanan, korsan temalı bir aksiyon-macera kooperatifi çok oyunculu oyunudur. Bir grup oyuncu bir korsan gemisi vasıtasıyla açık bir dünyayı dolaşıp keşfetmekte ve direksiyon, kaldırma yelkenleri, navigasyon, ateş topları ve diğer görevler gibi farklı roller üstlenmektedir. Oyuncular araştırmalara başlar, yağma tutar ve diğer oyuncularla savaşa girerler. Thieves Denizi, oyuncuların gruplarının maceraları boyunca düzenli olarak karşılaşacakları ortak bir dünya oyunu. Oyun, karikatürize bir sanat stiline ve oyuncuların gemi toplarına atılmasına izin veren abartılı fizik özelliklerine sahiptir.", "Rare Ltd", 777, "Sea of Thieves", new DateTime(2017, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun5.jpg", "Xbox Game Studios", false },
                    { 4, "4A Games'in hazırladığı Metro Exodus, en sürükleyici oyun dünyalarından birinde ölümcül dövüşleri ve gizliliği, keşif ve hayatta kalma korkusuyla birleştiren destansı, hikaye tabanlı bir birinci şahıs nişancı oyunudur. Dmitry Glukhovsky'nin romanlarından esinlenilmiştir.Oyun 2036 yılında geçmektedir.Oyunda nükleer savaşın dünyayı mahvetmesinin üstünden çeyrek yüzyıl geçmiştir, hayatta kalan birkaç bin kişi Moskova'nın harabelerinin altında, Metro tünellerinde hayatta kalmaya çalışmaktadır. Bu kişiler zehirli elementlere dayanmış, mutant yaratıklarla ve doğa üstü korkularla savaşmış, iç savaşın yaralarını tatmışdır. Oyunun amacı , Artyom olarak Metro'dan kaçmak ve Doğuda yeni bir yaşam aramak için kıyamet sonrası vahşi Rus doğasında geçen inanılmaz bir macerada bir grup Spartalı Korucuya öncülük etmektir.", "4A Games", 278, "Metro Exodus", new DateTime(2019, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun4.jpg", "Deep Silver", false },
                    { 3, "Tom Clancy's Rainbow Six Siege, oyuncuların bir anti-terörist birimi olan Rainbow takımından değişik operatörler olarak oynayabileceği birinci şahıs nişancı türünde bir video oyunudur. Bu operatörlerin değişik uyrukları, ekipmanları, yetenekleri ve işlevleri vardır. Oyunda takım çalışması kuşatma anlamına gelen Siege ismiyle desteklenirken, oyuncuların düşmanlarını yenebilmesi için güçlerini birleştirmeleri amaçlanmıştır. Aynı zamanda oyuncular arasındaki iletişimi güçlendirmek için oyun içinde sesli olarak iletişim sağlanabilmektedir. Oyuncular aynı zamanda oyun başlamadan önce saldırılarının veya savunmalarının ne şekilde olacağıyla ilgili plan yapabilmektedir. Saldırı takımı çevreyi araştırmak, düşmanlarının ve hedeflerin yerlerini tespit edebilmek için küçük dronelar gönderebilirken, savunma takımı da saldırıyı önleyebilmek için kapı, duvar gibi yapıları güçlendirmek amacıyla çeşitli barikatlar döşeyebilmektedir. Saldırı takımı, saldırı için birden fazla başlama noktasından birini seçebilmektedir. Oyundaki haritalar çok büyük değildir.", "Ubisoft Montreal", 659, "Tom Clancy's Rainbow Six Siege", new DateTime(2015, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun3.jpg", "Ubisoft", false },
                    { 2, "Oyun Kaliforniya eyaletinin güneyini temel alarak oluşturulmuş olan San Andreas eyaletinde geçmektedir. San Andreas, büyük ölçüde Los Angeles şehrine dayanılarak oluşturulmuş olan Los Santos adlı şehirden (GTA San Andreas oyunundakinin güncellenmiş hali) ve büyük kırsal alanlardan oluşmaktadır. Seride bir ilk olarak oyunda üç ana karakter bulunmaktadır: Michael De Santa, Trevor Philips ve Franklin Clinton.  Oyundaki üç karakterden her birinin farklı alanlarda farklı yetenekleri ve güçleri vardır. Oyuncular tek oyunculu modda oyunun hikayesini oynayarak ya da çok oyunculu modda kendi oluşturdukları karakterlerle başka oyuncularla oynayarak zaman geçirebilirler.", "Rockstar North", 1536, "Grand Theft Auto V", new DateTime(2013, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun2.jpg", "Rockstar Games", false },
                    { 1, "Oyun Hades’in oğlu Zagreus’un babasına baş kaldırmasını konu almaktadır. Zagreus babasına yeraltı dünyasından çıkacağını söyler. Babasını bunu başaramayacağını söylese de Zagreus yeraltı dünyasından çıkmak için yola koyulur. Bu yolculukta Zagreus’un karşısına birçok zorlu düşman çıkacaktır. Oyuncular Zagreus’u yöneterek zorlu düşmanlarla savaşacak; elde edindikleri yeni eşyalarla güçlenmeye ve Zagreus’un amacına ulaşmasını sağlamaya çalışacaktır.", "Supergiant Games", 814, "Hades", new DateTime(2018, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun1.jpg", "Supergiant Games", false },
                    { 15, "Şimdiye kadarki en kapsamlı F1 oyunu olan F1 2020 ile direksiyon başına geçip dünyanın en iyi sürücüleriyle yarışın. F1 2020 ile oyuncular ilk kez kendi F1 ekibini oluşturma imkanına kavuşuyor. Sürücü oluşturup, sponsor ve motor tedarikçisi seçip ekip arkadaşı tuttuktan sonra gruptaki 11. ekip olarak yarışabilirsiniz. Yeni tesisler oluşturun, zamanla ekibinizi geliştirin ve yarışlarda en tepeye oturun.", "Codemasters", 702, "F1 2020", new DateTime(2020, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun15.jpg", "Codemasters", false },
                    { 6, "Cyberpunk 2077 güç, gösteriş ve vücut modifikasyonu çılgınlığına kapılmış Night City kümekentinde geçen bir açık dünya aksiyon macera hikâyesidir. Kanun kaçağı paralı asker V olarak oyna ve ölümsüzlüğün anahtarı olan eşsiz bir implantın peşine düş. Karakterinin sibergereçlerini, yeteneklerini ve oynanış stilini özelleştir; kararların hikâyeyi ve dünyayı değiştirdiği devasa bir şehri keşfet.", "CD Projekt Red", 2956, "Cyberpunk 2077", new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "oyun6.jpg", "CD Projekt Red", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "8e317364-e21d-5613-a6d7-9413e041cdb9", "2" },
                    { "8e117364-e21d-4613-a6d7-9423e041cdb9", "1" },
                    { "8e217364-e21d-5613-a6d7-9413e041cdb9", "2" },
                    { "8e117364-e21d-5613-a6d7-9413e041cdb9", "2" },
                    { "8e117364-e21d-4713-a6d7-9423d041edb9", "1" }
                });

            migrationBuilder.InsertData(
                table: "OyunKategorisi",
                columns: new[] { "OyunID", "KategoriID" },
                values: new object[,]
                {
                    { 17, 5 },
                    { 22, 8 },
                    { 22, 7 },
                    { 22, 3 },
                    { 22, 1 },
                    { 21, 8 },
                    { 21, 7 },
                    { 21, 5 },
                    { 21, 3 },
                    { 20, 8 },
                    { 20, 7 },
                    { 20, 3 },
                    { 23, 1 },
                    { 19, 7 },
                    { 19, 3 },
                    { 19, 1 },
                    { 18, 8 },
                    { 18, 7 },
                    { 18, 5 },
                    { 18, 3 },
                    { 17, 8 },
                    { 17, 7 },
                    { 17, 3 },
                    { 19, 8 },
                    { 23, 2 },
                    { 16, 8 },
                    { 28, 8 },
                    { 28, 7 },
                    { 28, 6 },
                    { 28, 2 },
                    { 28, 1 },
                    { 27, 8 },
                    { 27, 7 },
                    { 27, 6 },
                    { 27, 5 },
                    { 27, 2 },
                    { 26, 8 },
                    { 26, 2 },
                    { 26, 1 },
                    { 25, 7 },
                    { 25, 6 },
                    { 25, 2 },
                    { 25, 1 },
                    { 24, 7 },
                    { 24, 6 },
                    { 24, 2 },
                    { 24, 1 },
                    { 23, 8 },
                    { 23, 7 },
                    { 23, 5 },
                    { 23, 6 },
                    { 16, 7 },
                    { 16, 3 },
                    { 8, 1 },
                    { 7, 8 },
                    { 7, 7 },
                    { 7, 5 },
                    { 7, 4 },
                    { 7, 1 },
                    { 6, 7 },
                    { 6, 1 },
                    { 5, 8 },
                    { 5, 7 },
                    { 5, 1 },
                    { 8, 4 },
                    { 4, 7 },
                    { 4, 2 },
                    { 4, 1 },
                    { 3, 8 },
                    { 3, 7 },
                    { 3, 4 },
                    { 3, 1 },
                    { 2, 8 },
                    { 2, 7 },
                    { 2, 4 },
                    { 2, 1 },
                    { 1, 7 },
                    { 4, 6 },
                    { 8, 5 },
                    { 8, 7 },
                    { 8, 8 },
                    { 15, 8 },
                    { 15, 7 },
                    { 15, 5 },
                    { 15, 4 },
                    { 15, 3 },
                    { 14, 7 },
                    { 14, 5 },
                    { 13, 7 },
                    { 13, 5 },
                    { 13, 4 },
                    { 12, 8 },
                    { 12, 4 },
                    { 12, 2 },
                    { 11, 8 },
                    { 11, 7 },
                    { 11, 5 },
                    { 11, 4 },
                    { 10, 7 },
                    { 10, 5 },
                    { 10, 4 },
                    { 9, 8 },
                    { 9, 7 },
                    { 9, 5 },
                    { 9, 4 },
                    { 9, 3 },
                    { 16, 5 },
                    { 1, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Favori_OyunID",
                table: "Favori",
                column: "OyunID");

            migrationBuilder.CreateIndex(
                name: "IX_OyunKategorisi_KategoriID",
                table: "OyunKategorisi",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_Yorum_OyunID",
                table: "Yorum",
                column: "OyunID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Favori");

            migrationBuilder.DropTable(
                name: "Haber");

            migrationBuilder.DropTable(
                name: "OyunKategorisi");

            migrationBuilder.DropTable(
                name: "Yorum");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Kategori");

            migrationBuilder.DropTable(
                name: "Oyun");
        }
    }
}
