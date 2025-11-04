using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutocfgWriter.Utils
{
    internal class OtherUtils
    {
        /// <summary>
        /// 打开文件选择器 并返回路径 如果没有选择文件 那么就会返回 "Error Path"
        /// </summary>
        /// <returns></returns>
        public static string PopFileChoose() {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "cfg 文件 (.cfg)|*.cfg";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName; 
                }
            }

            return "Error Path";
        }

        /// <summary>
        /// 打开文件选择器 并返回路径 如果没有选择文件 那么就会返回 "Error Path"
        /// 但是这个你可以自定义提示词
        /// </summary>
        /// <param name="HelpWorld">提示词</param>
        /// <returns></returns>
        public static string PopFileChoose(string HelpWorld)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "HelpWorld";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
            }

            return "Error Path";
        }

        /// <summary>
        /// 打开文件夹选择器 并返回路径 如果没有选择文件夹 那么就会返回 "Error Path"
        /// </summary>
        /// <returns></returns>
        public static string PopFolderChoose() {
            using (FolderBrowserDialog folder = new FolderBrowserDialog()) { 
                if(folder.ShowDialog() == DialogResult.OK)
                    return folder.SelectedPath;
            }
            return "Error Path";
        }
    }
}
