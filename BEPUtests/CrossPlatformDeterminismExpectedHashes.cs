﻿using System.Collections.Generic;
namespace BEPUtests
{
	class CrossPlatformDeterminismExpectedHashes
	{
		public static readonly Dictionary<string, string[]> Hashes = new Dictionary<string, string[]>()
{
			{"DiscreteVsContinuousBenchmark", new string[] {"3ac96c2a7478a65ef0395f16fe174189",
"e2381e21d720448dbdc62bfa124cc4b1",
"56c25926ac5d7afcf749502cd1945dcf",
"276dd22f46572255433411dff1257fc8",
"28ee7e595df6da545e66fe8a82b78b6b",
"d99f194e872bdad2f9892dc697ebe104",
"98c48e49e494c79d3b577477bb00db2e",
"e0223e3e28aec76155d5412eb2ccc634",
"0d41d36a166d1a9efec26843841d2476",
"11b86f21e172a446f7107181b429d87d",
"6bc8608f9b04269224e28bb7910ffe38",
"043c9c2277cf6177a51931c343337755",
"2978e4a93d5a17f30f297e05704c1f80",
"87c81c840ffb8b0be5cd70753aaddbbd",
"c41b4e614577f29982d987cdb8e3ab6d",
"88c8c6a87dc2b81d84a5d2d75233d9a5",
"2dd08c6c960f51d8f83a99349d334294",
"83d2b35e97d904c39e67f0111b107e5e",
"0c1feeea1d1b92874420f5427181b8cd",
"c3ba7eb17465bd58e917907bac583aa4",
"6ef48046bebc03850c0a46d899052b2c",
"f46097c5385f3761036565b03f71dd36",
"09e63bff5a0576516b19298f48ca9a6e",
"0765027a4915ca32cbf6d802261edc37",
"2eb1ddcc94e951ca0ea04d6fb5e6bc3f",
"ef75a85bf086e43b9f5204c220b0a37d",
"0a0c13b9f2f1fffd13b96dea2515714a",
"3ebc95ec69f84374175d861133b4fd94",
"29ec5bf9948cef31e2d5339ec68f9e2f",
"17bedb7b86dac281f367eec1c2732562",
"8a1d3cda42ae0512416b35d99e38a4d8",
"0edd56d6f5bf2dff6b7edaf34fae7f44",
"5008edb7850568b31517b03ea72d3b09",
"b3b3026c013562b6bf6763e1fb59b6a9",
"bcfb943483ce2f2c6e58161c81e3b74e",
"2190f1190a0b4d9111b6d6890b45047b",
"f6ffc26865b1c36f354ea084bf491a36",
"c8d332003e9737284065d77ef50743ea",
"2c995086ec32b1a1cf42dbd507250a4e",
"1cd6937ac6a8cb0346e4b91a3a3c1390",
"75c5698864ffc8e7e446948855397a83",
"1e89b9e13fe795c1cb793b17d6cc8989",
"8b85b21a306f151f45894542acab166c",
"bf772a49d018c10a6e394fabb66ac238",
"1af35ac0be812e99b60bed035dea1896",
"30dd79d9afe889a3ab2072be1124ec96",
"245288f20c6597d9ab955b6b22fb1aaa",
"7d9022ddf55d38d0737ce0029b925d2a",
"10142bd669dcd535b898bfed729e0ea3",
"71799f1b96474c4d237b5f98247c689e"}},
			{"InverseKinematicsBenchmark", new string[] {"6f735a2395749e49e170a893361328c0",
"60efee9766c82fe39369a16fc8eb0d0c",
"526ff33f1ba628602bddd3a21bc4ca21",
"320caeadf4b3b3b91c0ffee88925c826",
"d5838ff60aa97889f79fd196cc7986e1",
"1c52d9749b943034a51b453dc2585627",
"07a8f8f5600ade86ea143a340c387d2e",
"fc70cd9b254027f52828bf2627506dc1",
"aec97d8af2a22c8438476d62f96ab715",
"0f47c27e24e27ff7c83bd467a61433be",
"e4358196e4ecf7a8ea58a15325ba4ec1",
"853dfde2b0ddd5e8fec62ebf9ec9adff",
"52f403b1a77eb3f2bc457127e6ed5bea",
"57655f4b39dac1a24c1f11ecfdec0f31",
"553dd3bfbf8b6fd8d072b7162488a514",
"dbc597f91eef689626a80e18188036ab",
"9d8074ad0ad577d9a6950028c583f197",
"52ad3ce05e6a125fc54461740dee5c90",
"4ad6b5c1558404fc47b7e142efa89cd2",
"a4af27c07015c39376b619f689ee467b",
"36e704af98bc7eb1fb04e2ee526f5325",
"e3cea3f72e793c171481b23237cde982",
"4ccddf894ab016e87767802f1a7831d9",
"06853d2989b1e9b32df99a3e9da658cd",
"ae1e43ddc941719278c8b2c81d72dfe7",
"1fdf0d544ecba363c0b777ee408905a8",
"82b168c68d48fe334b140dc9c9319d67",
"d298b424979889400a39b8cee3b5e59e",
"32aeb15fdadbdb269b809ee5db7a7b62",
"c04dde9e845811fd2a692a5e57c0d192",
"eb64ee18f8117c630f6a6af083c26114",
"fc79fe565232363413aeffcaae0f7895",
"3437b54b9bd348402d4d33e51d8eefa6",
"6eba7a1d8a5ab668864b54b96aaa925c",
"6d305fb6f9357aa398019b6191a8ee1d",
"73dded9121c51ea71361f236f5b40947",
"01af44a2bb68a32dfb78fa39e34b8718",
"3dbfbc4d31a6d724fb50f4fe7e9e7dd8",
"a783f7935dc0b3fbbe04ff6574dc787e",
"34576717966fbafee3697972d2390139",
"287e9a1a8377452a2c99e266d0302e7e",
"210e482b81d8c66eb0789032403c826e",
"3c1558f31a8bc95cf71516f1b95401f5",
"fd7a7d487c3af69fb1c892aaa23f84f9",
"ede632b7fa75c30dd37ec1b95ee47558",
"f8cf98ae95f60e55e47e2c6e4e858f93",
"bd03e10eca0bbfd937ba766b09de1415",
"215e68bf204f3801b3aecd1393e93a17",
"ccba0eeae61417d3fb964855856c1920",
"11e8c27bddf47dff631dfde0dcc9b38e"}},
			{"PathFollowingBenchmark", new string[] {"ecc1c943278798ec1cfc1a275cd68fba",
"62f5c4391ea4b80e61fec932453dbb94",
"9f462769cbde8500f177bea2c4a96d3b",
"1c69e17c2b6b707f8c807a1d3ab85712",
"4d86720c832be7757390d20215169ff5",
"bf194c22d64683f0fcbec1fca0d1a16d",
"214976963c7f36ad143a2c603ef43017",
"b09c256c735b7993be32f00888096a6a",
"d0df80b115962b15150720322f80f6d1",
"4c82f803a25138cb9c0ec0536d04d8a4",
"e5281bc2015bb254cda868b1e9084e74",
"23d9271c9298c206a285744a56149a0f",
"1dd901f24f531608d39b9428edc83630",
"024cd8ca3653b5e080fa13a170ea6bc8",
"2a0bcfaf6505792fa6287c579234ee7e",
"5af51c27c049d3a04c40619904f44b37",
"c6e5138cd9a66f1c5424154ad93b0dc1",
"ca1d788dabf60afc590cb96567dec273",
"b49274247a85ff89dfe0da71b4142176",
"bc9078c805218d8ff8df846c80dad816",
"80f8bf85ed77d52b5c5f783447fc1486",
"763f9f7e89e07af4f8a1d0d09cfeadcd",
"ecdf8ae72b9229421ffe2a878c5b0425",
"120e3a7a8c50bcf9d4d5b56d056aba89",
"f90e697ff0ac0edd01ce5816742c56c3",
"eab478835e0b078590b1feec964a82af",
"f3caa578cf7909ad3cd39568f0c17476",
"956de8b98fe5aeef6453f4587114ccb4",
"f73b969b6fee875da2ad7cd4d4ed463f",
"fac2166265b7dfce33fd5c49bc8f2d34",
"f2e8a829eb1865c3edfde7fcdf2df453",
"0f8cf2c74f055e78feb9bcc8fd5f2ee0",
"bb6ef75ee26a6b18ba165cd61893de28",
"e1b81f99aa7304b6fe8633653d5b2fd8",
"fb8b33c2209aa770c27db9576619f845",
"0552ca778a1183ac2362c4370058ec7d",
"a3da9ea4e5ffb2bf4e675d2cfd64dfee",
"2557a1a7521bdff0a1c9e071347e99c8",
"19a000f0b6e17e672aedb8218d3563dc",
"4d7ff17ea1f0e7861b9384d272f62c02",
"e1844fafd478ef836ecb5bc2ba61a24c",
"8334b740acc915a5d96a4ed7fa4eeb0d",
"e2dc84123c79d4e6030d802851edb115",
"60585568db05309d79bcfb9887eaf203",
"d9f88c2ff5030cf45081a1cec4fbaf7a",
"efcc309f9ef23c5cc6c76c803b8a52f2",
"c22161f937f8dbef15b30327ea94d965",
"6f38dbe162f5ea827c1229a624440c98",
"b90d47c28e2b67d1e221945f531b6392",
"6509c81899d34096c79454b2e5828e2b"}}
,
{"SelfCollidingClothBenchmark", new string[] {"3e19e003e934ca097c63c0d104d77240",
"5097b4e1466e59ce7a31dc45c8736b72",
"826a1c771056160309fc75cd705f4d99",
"05e11b10320f3fa1d40e7c45b58bf5ca",
"1b08d0309fa08bfecdf7ac651ebdc0d7",
"385bdb09917ecd6b314dd621f7c1163d",
"09619f3cdec180340d80606dd833a171",
"06eb0aa1694bfeec2958682d3b65136d",
"e7c06609f45d4ce6e35c882c8233bf3f",
"b490f7f82ed7096d3ab1f5155ec6db94",
"c52a1822cb8e391c8a2612ed60923e24",
"1d9d12eb46b250518d44692212a83bab",
"db7ac566cb50315700aa624ac4717d05",
"3f104acc9f1eebec7e15d562bcaa16b6",
"f82e4216437695f4cb98259cf7e4e137",
"aa835e0ad888fbff1ceff735a98f3727",
"efd7a85b9e26e9466afd20e56bf4205c",
"3f294654c2e4e9434b7e6760e08f35cf",
"c85875597689d75e6469ae81c143ef01",
"1a34707467dc87d34000b640da698262",
"76bbf52dd0d930f1dd56b58a120802e0",
"244258028fdf2e7cd8190957a6196d17",
"7b42e3379ccdf385e3671691677feeeb",
"1b5c4002d32972a641790eb551b55cdf",
"04a4157d942dc94c70d463028370ab99",
"7b27f9c9746052a832b0d02e68a1aa5c",
"a8eecd159a7d8863ea337e097c348d86",
"9147a334a9cda941c38b87541072dfa8",
"1279b3e091897dca7e3495a3abb21e31",
"30d2520cfcd599048bc02c03f94a0b9b",
"2129d6174ed683290678878052e4b4fb",
"6bc2e852154d361a4c7bf876bc38bcc4",
"98546f4efc12886e0db4b174b0871e3e",
"903a533a3f3ce68f3b268c1c609dcda2",
"6b4df5ca695e968434622d949d3a4644",
"6e5520c6669d38650ba36aef3e198711",
"f344eae8581d05c821b887b13f7d9903",
"e00a8f4f23757c5de8d80ae09c9ba6a2",
"1fb2b5eeb32475623709548878d89865",
"8b74bd9ef923b7ae63a374b45c36b953",
"cc465ba4e9ac3208a63694837eacf691",
"3de17b3f0d9d718efd3394d25d749c29",
"c56f1d2ac4ed896070b490f5941fad5f",
"a66cb56709df9049034c03f06fd46ad4",
"48489c5e43ad124d927288ad709eceb8",
"2d59d8de27327705baadff4e7b472205",
"c36d2a056e8a2e7ebdf9140dbb6f80a0",
"66f32ed24cbbf52160150779aaddbefe",
"99bea6b413905d992cfb1d1de6f15e9f",
"8f5feadf88bda419a3604f01cb72a99d"}}
,
{"PyramidBenchmark", new string[] {"893698f1dede72e443c827e7763a44c9",
"754ac19c91c3460114d473147bb9e659",
"96f501f71e26f02d4d264f433be03afb",
"6528b26921cc899d2b0dbc38a5b1782c",
"df4fa704c7fecee44afe49f33a6c89e3",
"0b17941b6df096322992b5987cecb25c",
"7f57e48432d3c8bb88ce3455c517ed4e",
"e3aa9f3edabe02c9cf2216efa522d7c4",
"58c1e624282a2f71da4a8b5e080bbd6a",
"9149780f574febd57243014c7af80bc6",
"d5a5a4a90f6a65c42d4baddd8278fcc2",
"f306bdac7e0efd5a6ebf105ab382b0f9",
"4919f3d0998d0a2a75795933758e0c06",
"726ee6b5a10c403c680ed128337bc648",
"8aa58af8feab7915b6fa48be9dbfdd4e",
"636632889aee16162a0551f7ec14ef69",
"84c5daf0f4ab503eaf05a26239847196",
"de08b3e4e6c5a9d597f4c7feb1a6ff43",
"2b59508b6da75a32839fc61f0c08ef2f",
"cefdc0413a803c4aff6fdaf3827a24cc",
"789283f97ce6158a7a3c9523f8a5dddc",
"6e784a5cc253cc44f24b0b1a6ae22334",
"890b86947d671cd918e558ff9fe59112",
"26bb568a68c939971a7016453b3b327d",
"82e92403264a05eab5ac66b749bffe6a",
"f756fe5cc29acd3352006c2ea3399a39",
"5e8990bcc32fa54de132556f8be31809",
"8e76a5bd225c1edb506808f862fd3256",
"011290d86d344752de3441451ab773da",
"e565330ace7bbb2897bd94055bb6cfc8",
"9eb5fecb973783ac9403e4c084ae8075",
"ddda18c23a333e236b36d304effaae6a",
"b26fb4aa88d4dba5fe3aee5e3da67af7",
"9768b7058fb7e17b8f75e536b73b332f",
"29c5f19f2a5aca9246ac5fdd00789067",
"07497f13fe8ce652cdd74a1573ffbf3d",
"cf81402a932480cb9d59b3ecb2cb6856",
"0e6aa52b40d4c825bd9d5393dfce37ac",
"bcfdf1d47e32a8e0e3a7b90709b658a4",
"f5f41ac4dafa97614fdcd1687c53073b",
"c45cbf51ecc13fa676a9292a6f59b2f4",
"0a7e23b28deb395503439110a1fff092",
"1a1541ea4f9b56d889f668d2f0237275",
"c0f27269acad8ad18e273db05d019d15",
"9936d9cbfee426359af9149ecd513cff",
"3c1a2f04fb9e77e6a997cfba39ac5e7f",
"1c11194468cbbf757794d0c8adcaf3ef",
"9956ada6caee615dd4bf6ac0d5cdefb2",
"5436dc42095e3e83a3d8c86c5aa9ef43",
"fe81ab6f2ec141d7ab523188934f493a"}}
};
	}
}
