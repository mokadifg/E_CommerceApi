using E_CommerceApi.Models;

namespace E_CommerceApi.Repository
{
    public class DataRepository
    {
        public static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Smartphone Pro Max",
                Description = "The latest flagship smartphone with advanced camera system and all-day battery life.",
                LongDescription = "Experience the next generation of mobile technology with the Smartphone Pro Max. Featuring a stunning 6.7-inch Super Retina XDR display, an advanced triple-camera system that takes your photography to the professional level, and a powerful A15 chip that delivers lightning-fast performance for gaming and augmented reality experiences. With all-day battery life and 5G capabilities, this smartphone keeps you connected and productive throughout your day.",
                Price = 999.99m,
                DiscountPrice = 899.99m,
                ImageUrl = "https://images.unsplash.com/photo-1592899677977-9c10ca588bbd",
                Images = new List<string>
                {
                    "https://images.unsplash.com/photo-1592899677977-9c10ca588bbd",
                    "https://images.unsplash.com/photo-1580910051074-3eb694886505",
                    "https://images.unsplash.com/photo-1598327105666-5b89351aff97"
                },
                Category = "electronics",
                Rating = 4.8,
                Reviews = 325,
                StockCount = 45,
                Specs = new Dictionary<string, object>
                {
                    { "display", "6.7-inch Super Retina XDR" },
                    { "processor", "A15 Bionic Chip" },
                    { "storage", "256GB" },
                    { "camera", "Triple 12MP camera system" },
                    { "battery", "4000mAh" }
                },
                Featured = true
            },
            new Product
            {
                Id = 2,
                Name = "Wireless Noise-Cancelling Headphones",
                Description = "Premium wireless headphones with adaptive noise cancellation and high-fidelity audio.",
                LongDescription = "Immerse yourself in your favorite music with these premium wireless headphones. Featuring adaptive noise cancellation technology that adjusts to your environment, these headphones deliver crystal-clear audio without distractions. With up to 30 hours of battery life, comfortable over-ear design, and intuitive touch controls, these headphones are perfect for long listening sessions, travel, or working from home.",
                Price = 349.99m,
                DiscountPrice = null,
                ImageUrl = "https://images.unsplash.com/photo-1546435770-a3e426bf472b",
                Images = new List<string>
                {
                    "https://images.unsplash.com/photo-1546435770-a3e426bf472b",
                    "https://images.unsplash.com/photo-1583394838336-acd977736f90",
                    "https://images.unsplash.com/photo-1584670747417-594a9412fba5"
                },
                Category = "electronics",
                Rating = 4.7,
                Reviews = 182,
                StockCount = 32,
                Specs = new Dictionary<string, object>
                {
                    { "type", "Over-ear" },
                    { "batteryLife", "30 hours" },
                    { "connectivity", "Bluetooth 5.0" },
                    { "noiseCancellation", "Adaptive" },
                    { "color", "Black" }
                },
                Featured = true
            },
            new Product
            {
                Id = 3,
                Name = "Ultra HD Smart TV 55\"",
                Description = "55-inch 4K Ultra HD Smart TV with HDR and built-in streaming apps.",
                LongDescription = "Transform your home entertainment experience with this 55-inch Ultra HD Smart TV. Featuring 4K resolution, HDR technology, and a wide color gamut, this TV delivers stunning picture quality with vivid colors and deep blacks. The smart platform gives you access to thousands of streaming apps, and the voice-enabled remote makes finding content easier than ever. With multiple HDMI and USB ports, you can connect all your devices for a complete entertainment setup.",
                Price = 699.99m,
                DiscountPrice = 599.99m,
                ImageUrl = "https://images.unsplash.com/photo-1593359677879-a4bb92f829d1",
                Images = new List<string>
                {
                    "https://images.unsplash.com/photo-1593359677879-a4bb92f829d1",
                    "https://images.unsplash.com/photo-1601944177325-f8867652837f",
                    "https://images.unsplash.com/photo-1509281373149-e957c6296406"
                },
                Category = "electronics",
                Rating = 4.5,
                Reviews = 208,
                StockCount = 18,
                Specs = new Dictionary<string, object>
                {
                    { "resolution", "4K Ultra HD (3840 x 2160)" },
                    { "displayType", "LED" },
                    { "refreshRate", "60Hz" },
                    { "smartPlatform", "WebOS" },
                    { "hdmiPorts", 3 }
                },
                Featured = false
            },
            new Product
            {
                Id = 4,
                Name = "Classic Cotton T-Shirt",
                Description = "Comfortable 100% cotton t-shirt with a modern fit, perfect for everyday wear.",
                LongDescription = "Add a versatile staple to your wardrobe with this classic cotton t-shirt. Made from premium 100% combed cotton for exceptional softness and durability, this t-shirt features a modern fit that's flattering without being too tight. The reinforced collar and double-stitched seams ensure it maintains its shape wash after wash. Available in multiple colors, this t-shirt is perfect for layering or wearing on its own year-round.",
                Price = 19.99m,
                DiscountPrice = null,
                ImageUrl = "https://images.unsplash.com/photo-1581655353564-df123a1eb820",
                Images = new List<string>
                {
                    "https://images.unsplash.com/photo-1581655353564-df123a1eb820",
                    "https://images.unsplash.com/photo-1622445275576-721325763afe",
                    "https://images.unsplash.com/photo-1598033129183-c4f50c736f10"
                },
                Category = "clothing",
                Rating = 4.3,
                Reviews = 412,
                StockCount = 150,
                Specs = new Dictionary<string, object>
                {
                    { "material", "100% Cotton" },
                    { "fit", "Regular" },
                    { "careInstructions", "Machine wash cold" },
                    { "origin", "Made in USA" },
                    { "availableSizes", new List<string> { "S", "M", "L", "XL", "XXL" } }
                },
                Featured = false
            },
            new Product
            {
                Id = 5,
                Name = "Stainless Steel Water Bottle",
                Description = "Double-walled insulated water bottle that keeps drinks cold for 24 hours or hot for 12 hours.",
                LongDescription = "Stay hydrated in style with this premium stainless steel water bottle. The double-walled vacuum insulation keeps your drinks cold for up to 24 hours or hot for up to 12 hours, making it perfect for hiking, office use, or everyday hydration. Made from high-quality 18/8 stainless steel that's both durable and BPA-free, this bottle features a leak-proof lid with a convenient carrying handle. Its sleek design fits most cup holders and bag side pockets for easy transport.",
                Price = 34.99m,
                DiscountPrice = 29.99m,
                ImageUrl = "https://images.unsplash.com/photo-1602143407151-7111542de6e8",
                Images = new List<string>
                {
                    "https://images.unsplash.com/photo-1602143407151-7111542de6e8",
                    "https://images.unsplash.com/photo-1610847244057-02a5d33e2f83",
                    "https://images.unsplash.com/photo-1589365278144-c9e705f843ba"
                },
                Category = "home",
                Rating = 4.6,
                Reviews = 275,
                StockCount = 85,
                Specs = new Dictionary<string, object>
                {
                    { "capacity", "750ml" },
                    { "material", "18/8 Stainless Steel" },
                    { "insulation", "Double-walled vacuum" },
                    { "lidType", "Screw top with handle" },
                    { "color", "Brushed Steel" }
                },
                Featured = true
            },
            new Product
            {
                Id = 6,
                Name = "Wireless Gaming Mouse",
                Description = "High-precision wireless gaming mouse with RGB lighting and customizable buttons.",
                LongDescription = "Elevate your gaming experience with this high-performance wireless gaming mouse. Featuring a high-precision 16,000 DPI optical sensor for pixel-perfect accuracy and ultra-low latency wireless connectivity, this mouse gives you the competitive edge in any game. The customizable RGB lighting with 16.8 million color options lets you personalize your setup, while the 6 programmable buttons can be configured to your play style. With up to 60 hours of battery life and a comfortable ergonomic design, you can game for hours in comfort.",
                Price = 69.99m,
                DiscountPrice = 59.99m,
                ImageUrl = "https://images.unsplash.com/photo-1563297007-0686b7003af7",
                Images = new List<string>
                {
                    "https://images.unsplash.com/photo-1563297007-0686b7003af7",
                    "https://images.unsplash.com/photo-1615663245857-ac93bb7c39e7",
                    "https://images.unsplash.com/photo-1527814050087-3793815479db"
                },
                Category = "electronics",
                Rating = 4.4,
                Reviews = 198,
                StockCount = 42,
                Specs = new Dictionary<string, object>
                {
                    { "sensor", "16,000 DPI optical" },
                    { "connectivity", "2.4GHz wireless / USB" },
                    { "buttons", "6 programmable buttons" },
                    { "batteryLife", "Up to 60 hours" },
                    { "weight", "95g" }
                },
                Featured = false
            },
            new Product
            {
                Id = 7,
                Name = "Handcrafted Ceramic Mug Set",
                Description = "Set of 4 handcrafted ceramic mugs, each with a unique glaze pattern and comfortable handle.",
                LongDescription = "Add a touch of artisanal charm to your morning routine with this set of 4 handcrafted ceramic mugs. Each mug is individually thrown on a potter's wheel and features a unique glaze pattern, ensuring no two are exactly alike. With a generous 12oz capacity and a comfortable ergonomic handle, these mugs are perfect for coffee, tea, or hot chocolate. The stoneware ceramic construction retains heat well and is both microwave and dishwasher safe for everyday convenience.",
                Price = 49.99m,
                DiscountPrice = null,
                ImageUrl = "https://images.unsplash.com/photo-1514228742587-6b1558fcca3d",
                Images = new List<string>
                {
                    "https://images.unsplash.com/photo-1514228742587-6b1558fcca3d",
                    "https://images.unsplash.com/photo-1578081827575-7c5e66dc5c14",
                    "https://images.unsplash.com/photo-1563826904577-6b72c5d75e53"
                },
                Category = "home",
                Rating = 4.9,
                Reviews = 87,
                StockCount = 24,
                Specs = new Dictionary<string, object>
                {
                    { "material", "Stoneware ceramic" },
                    { "capacity", "12oz" },
                    { "dimensions", "4\"H x 3.5\"D" },
                    { "care", "Dishwasher and microwave safe" },
                    { "includes", "Set of 4 mugs" }
                },
                Featured = false
            },
            new Product
            {
                Id = 8,
                Name = "Slim Leather Wallet",
                Description = "Minimalist leather wallet with RFID blocking technology and space for essential cards and cash.",
                LongDescription = "Streamline your everyday carry with this slim leather wallet. Crafted from full-grain leather that develops a beautiful patina over time, this wallet combines classic style with modern functionality. The thoughtful design includes space for up to 8 cards, a convenient ID window, and a slim pocket for folded cash, all while maintaining a compact profile that fits comfortably in your front pocket. Built-in RFID blocking technology protects your credit cards from unauthorized scanning.",
                Price = 39.99m,
                DiscountPrice = 34.99m,
                ImageUrl = "https://images.unsplash.com/photo-1627123424574-724758594e93",
                Images = new List<string>
                {
                    "https://images.unsplash.com/photo-1627123424574-724758594e93",
                    "https://images.unsplash.com/photo-1606816877038-d9a50a56609f",
                    "https://images.unsplash.com/photo-1630508269166-3c9aea8833b3"
                },
                Category = "accessories",
                Rating = 4.6,
                Reviews = 132,
                StockCount = 67,
                Specs = new Dictionary<string, object>
                {
                    { "material", "Full-grain leather" },
                    { "dimensions", "4\"W x 3\"H x 0.4\"D" },
                    { "cardSlots", 8 },
                    { "features", "RFID blocking, ID window" },
                    { "color", "Brown" }
                },
                Featured = true
            },
            new Product
            {
                Id = 9,
                Name = "Smart Fitness Tracker",
                Description = "Advanced fitness tracker with heart rate monitoring, sleep tracking, and 7-day battery life.",
                LongDescription = "Take control of your health and fitness with this advanced smart fitness tracker. Track your daily activity including steps, distance, calories burned, and active minutes. The 24/7 heart rate monitoring provides insights into your cardio health, workout intensity, and calorie burn. Advanced sleep tracking analyzes your sleep stages to help you understand and improve your sleep quality. With a water-resistant design and up to 7 days of battery life, this tracker keeps up with your active lifestyle. The companion app provides detailed analytics and personalized insights to help you reach your health goals.",
                Price = 89.99m,
                DiscountPrice = 79.99m,
                ImageUrl = "https://images.unsplash.com/photo-1575311373937-040b8e1fd5b6",
                Images = new List<string>
                {
                    "https://images.unsplash.com/photo-1575311373937-040b8e1fd5b6",
                    "https://images.unsplash.com/photo-1510771463146-e89e6e86560e",
                    "https://images.unsplash.com/photo-1509233725247-49e657c54213"
                },
                Category = "electronics",
                Rating = 4.5,
                Reviews = 246,
                StockCount = 53,
                Specs = new Dictionary<string, object>
                {
                    { "display", "OLED touchscreen" },
                    { "batteryLife", "Up to 7 days" },
                    { "waterResistance", "5 ATM" },
                    { "sensors", "Heart rate, accelerometer, gyroscope" },
                    { "compatibility", "iOS and Android" }
                },
                Featured = true
            },
            new Product
            {
                Id = 10,
                Name = "Cast Iron Skillet",
                Description = "Pre-seasoned 10.25-inch cast iron skillet, perfect for searing, baking, broiling, and more.",
                LongDescription = "Experience the versatility and durability of this classic 10.25-inch cast iron skillet. Pre-seasoned with vegetable oil for a natural, easy-release finish that improves with use, this skillet is ready to use right out of the box. The unparalleled heat retention and even heating of cast iron makes it perfect for searing, sautéing, baking, broiling, and frying. The helper handle provides added support when moving between stovetop and oven. This heirloom-quality piece can last for generations with proper care and becomes naturally non-stick the more you use it.",
                Price = 29.99m,
                DiscountPrice = null,
                ImageUrl = "https://images.unsplash.com/photo-1574181609941-50c9722f2e49",
                Images = new List<string>
                {
                    "https://images.unsplash.com/photo-1574181609941-50c9722f2e49",
                    "https://images.unsplash.com/photo-1620809876622-3c9a8555359a",
                    "https://images.unsplash.com/photo-1626251376203-230f5f4620a3"
                },
                Category = "home",
                Rating = 4.8,
                Reviews = 372,
                StockCount = 96,
                Specs = new Dictionary<string, object>
                {
                    { "diameter", "10.25 inches" },
                    { "material", "Cast iron" },
                    { "weight", "5.2 lbs" },
                    { "preSeasoned", "Yes" },
                    { "compatible", "Stovetop, oven, grill, campfire" }
                },
                Featured = false
            },
            new Product
            {
                Id = 11,
                Name = "Leather Crossbody Bag",
                Description = "Stylish genuine leather crossbody bag with adjustable strap and multiple compartments.",
                LongDescription = "Combine style and practicality with this genuine leather crossbody bag. Crafted from high-quality leather that gets better with age, this bag features a spacious main compartment with a zip closure for security, plus additional interior and exterior pockets to keep your essentials organized. The adjustable strap allows for comfortable carrying at your preferred length, while the sleek, minimalist design transitions seamlessly from day to night. Perfect for travel, shopping, or everyday use, this versatile bag adds a touch of sophistication to any outfit.",
                Price = 79.99m,
                DiscountPrice = null,
                ImageUrl = "https://images.unsplash.com/photo-1590874103328-eac38a683ce7",
                Images = new List<string>
                {
                    "https://images.unsplash.com/photo-1590874103328-eac38a683ce7",
                    "https://images.unsplash.com/photo-1614179689702-66d01a81de15",
                    "https://images.unsplash.com/photo-1601912262338-74a0308f37d0"
                },
                Category = "accessories",
                Rating = 4.7,
                Reviews = 154,
                StockCount = 39,
                Specs = new Dictionary<string, object>
                {
                    { "material", "Genuine leather" },
                    { "dimensions", "9\"W x 7\"H x 3\"D" },
                    { "pockets", "1 main, 2 interior, 1 exterior" },
                    { "closure", "Zipper" },
                    { "strap", "Adjustable, 48\" max" }
                },
                Featured = true
            },
            new Product
            {
                Id = 12,
                Name = "Portable Bluetooth Speaker",
                Description = "Waterproof portable Bluetooth speaker with 20 hours of playtime and rich, immersive sound.",
                LongDescription = "Take your music anywhere with this rugged, waterproof Bluetooth speaker. Delivering powerful, immersive sound with deep bass and clear highs, this speaker transforms any location into your personal concert venue. The IPX7 waterproof rating means it can handle splashes, rain, and even brief submersion, making it perfect for pool parties or beach days. With up to 20 hours of playtime on a single charge and built-in power bank functionality to charge your devices, you'll never have to cut the music short. The durable fabric cover and rubber housing protect against drops and bumps for worry-free portability.",
                Price = 129.99m,
                DiscountPrice = 99.99m,
                ImageUrl = "https://images.unsplash.com/photo-1608043152269-423dbba4e7e1",
                Images = new List<string>
                {
                    "https://images.unsplash.com/photo-1608043152269-423dbba4e7e1",
                    "https://images.unsplash.com/photo-1563330232-57114bb0823c",
                    "https://images.unsplash.com/photo-1574435298396-f3be6023c832"
                },
                Category = "electronics",
                Rating = 4.6,
                Reviews = 285,
                StockCount = 48,
                Specs = new Dictionary<string, object>
                {
                    { "waterproofRating", "IPX7" },
                    { "batteryLife", "20 hours" },
                    { "connectivity", "Bluetooth 5.1" },
                    { "range", "Up to 100 feet" },
                    { "power", "30 watts" }
                },
                Featured = false
            }
        };

        public static List<Category> Categories = new List<Category>
        {
            new Category
            {
                Id = 1,
                Name = "electronics",
                DisplayName = "Electronics",
                Description = "Latest gadgets and electronic devices"
            },
            new Category
            {
                Id = 2,
                Name = "clothing",
                DisplayName = "Clothing",
                Description = "Stylish and comfortable apparel"
            },
            new Category
            {
                Id = 3,
                Name = "home",
                DisplayName = "Home & Kitchen",
                Description = "Essentials for your home"
            },
            new Category
            {
                Id = 4,
                Name = "accessories",
                DisplayName = "Accessories",
                Description = "Fashionable accessories to complete your look"
            }
        };

        public static List<Order> Orders = new List<Order>();
    }
}
