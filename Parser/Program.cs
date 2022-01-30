using Parser;

InfoParser parser = new InfoParser();
Converter converter = new Converter();

string result = parser.Parse("https://search-maps.yandex.ru/v1/?apikey=a31ab3e4-acea-4b6f-be2e-c004f538e78b&text=Санкт-Петербург, Адмиралтейский район, общеобразовательная школа №&lang=ru_RU&results=500");
converter.ConvertToJson("C:\\Users\\Anastasiia.Posulikhi\\RiderProjects\\IndexiumUI_\\Parser\\AdmiralteiskyDistrictSchools.json", result);