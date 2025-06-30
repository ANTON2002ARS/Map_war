﻿using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Map_war
{
    
    internal class Save_Map
    {

        public void file_save()
        {
            // markers — это List<MapMarker>, который вы наполняете в ходе работы приложения

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Map_war (*.map)|*.map";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Form1 form = new Form1();
                File.WriteAllText(sfd.FileName, JsonConvert.SerializeObject(form.Markers, Formatting.Indented));
                //File.WriteAllText(sfd.FileName, json);
            }
        }

        public List<Map_Marker> file_open()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JSON files (*.map)|*.map";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json = File.ReadAllText(ofd.FileName);
                    List<Map_Marker> markers = JsonConvert.DeserializeObject<List<Map_Marker>>(json);
                    return markers;
                }
                catch
                {
                    MessageBox.Show("Не удалось открыть формат карты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                
            }
            return null;
        }
    }
}