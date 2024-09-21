// See https://aka.ms/new-console-template for more information
using DailyTools;
using DailyTools.Services;

Console.WriteLine("Hello, World!");

string sectors = "Capital Goods,Financial,Automobile,Diversified,Construction,Services,Healthcare,Consumer Staples,Textiles,Technology,Metals, Pharmaceuticals,Chemicals Ltd,Materials, Others";

string[] str = sectors.Split(',');
//foreach (var item in str)
//{
//    //Console.WriteLine($"sectornames.Add(\"{item}\");");
//}

IMutualFundService mutualFundService = new ETMoneyMutualFundService(true);
//mutualFundService.ProcessETSmallStockMoneyData();
mutualFundService.ProcessETInfrastructureStockMoneyData();

mutualFundService.GenerateData();

//string path = "C:\\rlscode\\dev\\Conga.Revenue.Config.Rajan\\Conga.Revenue.Config.DataTool\\PublishClasses\\GenSrc\\TN_ORG_55debe94_f9c8_49d4_8447_158bda7781ac";

//DirectoryInfo directory = new DirectoryInfo(path);

//FileInfo[] files = directory.GetFiles("*.cs", SearchOption.AllDirectories);

//string output = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\CodeOutput1.txt");
//if (!File.Exists(output))
//{
//    File.Create(output);
//}

//if (files.Length > 0)
//{
//    for (int i = 0; i < files.Length; i++)
//    {
//        var file = files[i];

//        File.AppendAllText(output, $"{Path.GetFileNameWithoutExtension(file.Name)}.GetSingleton();\n");
//    }
//}

