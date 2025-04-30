using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Dropbox.Api;
using Dropbox.Api.Files;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace ShadowKey
{
    class Dropbox
    {
        private static string Token;
        private static DropboxClient dbx;

        public static void Initialize()
        {
            try
            {
                Token = File.ReadAllText("token.txt");
                dbx = new DropboxClient(Token);
            }
            catch (FileNotFoundException)
            {
                MaterialMessageBox.Show("Please add token.txt file and put the dropbox token inside it !\nThen restart the tool", "Error in Dropbox", MessageBoxButtons.OK, MessageBoxIcon.Error, false);
                Environment.Exit(0);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }
        public static async Task<bool> UploadFile(string username, string file, string fileToUpload)
        {
            DropboxClient dbx = new DropboxClient(Token);
            using (var mem = new MemoryStream(File.ReadAllBytes(fileToUpload)))
            {
                try
                {
                    var updated = await dbx.Files.UploadAsync(
                        "/Apps/ShadowApp/" + username + "/" + file,
                        WriteMode.Overwrite.Instance,
                        body: mem);
                    return true;

                }
                catch
                {

                }
                return false;
            }
        }
        public static async Task DownloadFile(string username, string file, string local_Path)
        {
            using (var response = await dbx.Files.DownloadAsync("/Apps/ShadowApp/" + username + "/" + file))
            {
                using (var fileStream = File.Create(local_Path))
                {
                    (await response.GetContentAsStreamAsync()).CopyTo(fileStream);
                }
                await deleteFile(username, file);
            }
        }
        public static async Task<(string, string)> GetFiles(string username)
        {
            bool more = true;
            string FilesName = string.Empty;
            string Usernames = string.Empty;
            try
            {
                var listFolders = await dbx.Files.ListFolderAsync("/Apps/ShadowApp/" + username + "/");
                while (more)
                {
                    foreach (var item in listFolders.Entries.Where(i => i.IsFile))
                    {
                        FilesName += item.Name + "\n";
                        Usernames += item.Name.Split('_')[0] + "\n";
                    }
                    more = listFolders.HasMore;
                    if (more)
                    {
                        listFolders = await dbx.Files.ListFolderContinueAsync(listFolders.Cursor);
                    }
                }
                if (!string.IsNullOrEmpty(FilesName))
                    return (Usernames.TrimEnd('\r', '\n'), FilesName.TrimEnd('\r', '\n'));
            }
            catch (Exception ex)
            {
                //expired_access_token
                if (ex.Message.Contains("expired_access_token"))
                {
                    MaterialMessageBox.Show("Please refresh the token in token.txt !\nThen restart the tool", "Error in Dropbox", MessageBoxButtons.OK, MessageBoxIcon.Error, false);
                    Environment.Exit(0);
                }
            }
            return (null, null);
        }      
        public static async Task deleteFile(string Username, string fileName)
        {
            var rr = await dbx.Files.DeleteAsync($"/Apps/ShadowApp/{Username}/{fileName}");
        }
    }
}