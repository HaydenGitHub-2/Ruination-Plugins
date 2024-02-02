using Microsoft.VisualBasic.Devices;
using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Xml.Linq;

namespace Ruinations_Plugings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pcname = Environment.UserName;
            string folderPath = "C:\\Users\\" + pcname + "\\AppData\\Local\\RuinationFN_Swapper\\Plugins\\";


            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string fileName = "1706817911_Tigeress_.json";
            string filePath = Path.Combine(folderPath, fileName);

            string pluginName = "Tigeress";

            var dataObject = new
            {
                Type = "uefnskin",
                ID = "7IP1d8loiUHI4kql3ZuGaV5BiZhJcBM3",
                Name = "Tigeress",
                Description = "By Hayden.",
                Rarity = "Rare",
                Icon = "https://fortnite-api.com/images/cosmetics/br/cid_683_athena_commando_f_tigerfashion/icon.png",
                Skin = new
                {
                    Mesh = "/Swaps/Tigeress/Tigress",
                    Skeleton = "/Game/Characters/Player/Female/Medium/Base/SK_M_Female_Base_Skeleton.SK_M_Female_Base_Skeleton",
                    Animation = "/BRCosmetics/Characters/Player/Female/Medium/Bodies/F_MED_Tiger_Fashion/Meshes/Parts/F_MED_Tiger_Fashion_FaceAcc_AnimBP.F_MED_Tiger_Fashion_FaceAcc_AnimBP_C",
                    PartmodifierBlueprint = "",
                    IdleEffectNiagara = ""
                },
                Files = new
                {
                    pak = "https://cdn.discordapp.com/attachments/943541247044374603/1202772931743326298/plugin.pak?ex=65ceac95&is=65bc3795&hm=b08bea675d5f0d5078b9b6d51b7eb292eaefa40e1bdee28376e5e6ae2a0eeb6e&",
                    sig = "https://cdn.discordapp.com/attachments/943541247044374603/1202772932078735400/plugin.sig?ex=65ceac95&is=65bc3795&hm=666af91922b558ea9f14834304eee25b030935ab5c508ea7e43d8016e71452c7&",
                    ucas = "https://cdn.discordapp.com/attachments/943541247044374603/1202713845697749042/plugin.ucas?ex=65ce758e&is=65bc008e&hm=daf35829f412b2c8d5a1deee4bf54ff8cdd9bc76b422cd3d3a5599c80282f34d&",
                    utoc = "https://cdn.discordapp.com/attachments/943541247044374603/1202772931386548254/plugin.utoc?ex=65ceac95&is=65bc3795&hm=bbce2f0be7ed470981b0a7d984aa947d1cfd17ab56f08f3f96891b0aed8b2388&"
                },
                Materials = new[]
            {
                "/BRCosmetics/Characters/Player/Female/Medium/Bodies/F_MED_Tiger_Fashion/Materials/F_MED_Tiger_Fashion_Body.F_MED_Tiger_Fashion_Body",
                "/BRCosmetics/Characters/Player/Female/Medium/Bodies/F_MED_Tiger_Fashion/Materials/T_F_MED_Tiger_Fashion_Acc.T_F_MED_Tiger_Fashion_Acc",
                "/Game/Characters/Player/Female/Medium/Heads/F_MED_ASN_Starfish_Head_01/Materials/F_MED_ASN_Starfish_Head_01_Hair.F_MED_ASN_Starfish_Head_01_Hair",
                "/Game/Characters/Player/Female/Medium/Heads/F_MED_ASN_Starfish_Head_01/Materials/F_MED_ASN_Starfish_Head_01.F_MED_ASN_Starfish_Head_01",
                "/Game/Characters/Player/Female/Medium/Heads/F_MED_ASN_Starfish_Head_01/Materials/F_MED_ASN_Starfish_Head_01.F_MED_ASN_Starfish_Head_01"
            }
            };

            try
            {
                string jsonData = JsonSerializer.Serialize(dataObject, new JsonSerializerOptions
                {
                    WriteIndented = true
                });

                File.WriteAllText(filePath, jsonData);

                Console.WriteLine("The " + pluginName + "was added.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding: " + pluginName + ": " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string pcname = Environment.UserName;
            string folderPath = "C:\\Users\\" + pcname + "\\AppData\\Local\\RuinationFN_Swapper\\Plugins\\";


            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string fileName = "1706565667_Caper_.json";
            string filePath = Path.Combine(folderPath, fileName);

            string pluginName = "Caper";

            var dataObject = new
            {
                Type = "uefnskin",
                ID = "AZPP3IBZ1yB9O8AOeyzg7XFwahay74fy",
                Name = "Caper",
                Description = "By Hayden.",
                Rarity = "Epic",
                Icon = "https://fortnite-api.com/images/cosmetics/br/character_jumpsuit_scrap_mutable/smallicon.png",
                Skin = new
                {
                    Mesh = "/Swaps/Caper/Caper.Caper",
                    Skeleton = "/Game/Characters/Player/Female/Medium/Base/SK_M_Female_Base_Skeleton.SK_M_Female_Base_Skeleton",
                    Animation = "/MeshCosmetics/Jumpsuit/JumpsuitAdapter_Fortnite_M_Avg_Player_Skeleton_AnimBlueprint.JumpsuitAdapter_Fortnite_M_Avg_Player_Skeleton_AnimBlueprint_C",
                    PartmodifierBlueprint = "",
                    IdleEffectNiagara = ""
                },
                Files = new
                {
                    pak = "https://cdn.discordapp.com/attachments/943541247044374603/1201641041757999256/plugin.pak?ex=65ca8e6d&is=65b8196d&hm=f2921400e49f16e6f829799e1a5871b555525c3260b885b0f9c1df55b1970aaa&",
                    sig = "https://cdn.discordapp.com/attachments/943541247044374603/1201641042089365625/plugin.sig?ex=65ca8e6d&is=65b8196d&hm=bb476bdeb4d94c6a9894acde1c05db2ea765c84ff94ab2b8ef983a80dd7b578c&",
                    ucas = "https://cdn.discordapp.com/attachments/943541247044374603/1201641042693337188/plugin.ucas?ex=65ca8e6d&is=65b8196d&hm=984aa5aad276378f86bebebea182a1a7424fd4fa7c2671f3b7b00ee953610bf5&",
                    utoc = "https://cdn.discordapp.com/attachments/943541247044374603/1201641041216942151/plugin.utoc?ex=65ca8e6d&is=65b8196d&hm=990942c16c79eff1efdef4a3dda46a4c563e69b1fecdce0896bb585b00012304&"
                },
                Materials = new[]
            {
                "/MeshCosmetics/Jumpsuit/F_MED_Jumpsuit_Scrap/Materials/MI_F_MED_Jumpsuit_Scrap_Body.MI_F_MED_Jumpsuit_Scrap_Body",
                "/MeshCosmetics/Jumpsuit/F_MED_Jumpsuit_Scrap/Materials/MI_F_MED_Jumpsuit_Scrap_Eyes.MI_F_MED_Jumpsuit_Scrap_Eyes",
                "/MeshCosmetics/Jumpsuit/F_MED_Jumpsuit_Scrap/Materials/MI_F_MED_Jumpsuit_Scrap_Head.MI_F_MED_Jumpsuit_Scrap_Head",
                "/MeshCosmetics/Jumpsuit/F_MED_Jumpsuit_Scrap/Materials/MI_F_MED_Jumpsuit_Scrap_FaceAcc.MI_F_MED_Jumpsuit_Scrap_FaceAcc"
            }
            };

            try
            {
                string jsonData = JsonSerializer.Serialize(dataObject, new JsonSerializerOptions
                {
                    WriteIndented = true
                });

                File.WriteAllText(filePath, jsonData);

                Console.WriteLine("The " + pluginName + "was added.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding: " + pluginName + ": " + ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string pluginName = "1706817911_Tigeress_";
            string pcname = Environment.UserName;
            string folderPath = Path.Combine("C:\\Users", pcname, "AppData", "Local", "RuinationFN_Swapper", "Plugins");
            string filePath = Path.Combine(folderPath, pluginName + ".json");

            if (Directory.Exists(filePath))
            {
                Directory.Delete(filePath, true);
            }
            else
            {
                Console.WriteLine("Directory not found: " + folderPath);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string pluginName = "1706565667_Caper_";
            string pcname = Environment.UserName;
            string folderPath = Path.Combine("C:\\Users", pcname, "AppData", "Local", "RuinationFN_Swapper", "Plugins");
            string directoryPath = Path.Combine(folderPath, pluginName);

            if (Directory.Exists(directoryPath))
            {
                Directory.Delete(directoryPath, true);
            }
            else
            {
                Console.WriteLine("Directory not found: " + directoryPath);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}