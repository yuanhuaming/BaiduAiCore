using System.Collections.Generic;
using System.IO;
using Baidu.Aip.Face;

namespace Baidu.Aip.Demo
{
    public  class FaceDemo
    {

        private readonly Face.Face client = null;

        public FaceDemo(string apiKey, string secretKey)
        {
            client = new Face.Face(apiKey, secretKey);
        }

        public void FaceMatch(string[] filePaths)
        {
            var images = new List<byte[]>();
            foreach (var filePath in filePaths)
            {
                images.Add(File.ReadAllBytes(filePath));
            }

            // 人脸对比
            var result = client.FaceMatch(images);
        }

        public void FaceDetect(string filePath)
        {

            var image = File.ReadAllBytes(filePath);
            var options = new Dictionary<string, object>
            {
                {"face_fields", "beauty,age"}
            };
            var result = client.FaceDetect(image, options);
        }

        public void FaceRegister(string filePath)
        {

            var image1 = File.ReadAllBytes(filePath);

            var result = client.User.Register(image1, "uid", "user info here", new[] { "groupId" });
        }

        public void FaceUpdate(string filePath)
        {

            var image1 = File.ReadAllBytes(filePath);

            var result = client.User.Update(image1, "uid", "groupId", "new user info");
        }

        public void FaceDelete()
        {

            var result = client.User.Delete("uid");
            result = client.User.Delete("uid", new[] { "group1" });
        }

        public void FaceVerify(string filePath)
        {

            var image1 = File.ReadAllBytes(filePath);

            var result = client.User.Verify(image1, "uid", new[] { "groupId" }, 1);
        }

        public void FaceIdentify(string filePath)
        {

            var image1 = File.ReadAllBytes(filePath);

            var result = client.User.Identify(image1, new[] { "groupId" }, 1, 1);
        }

        public void UserInfo()
        {

            var result = client.User.GetInfo("uid");
        }

        public void GroupList()
        {

            var result = client.Group.GetAllGroups(0, 100);
        }

        public void GroupUsers()
        {

            var result = client.Group.GetUsers("groupId", 0, 100);
        }

        public void GroupAddUser()
        {

            var result = client.Group.AddUser(new[] { "toGroupId" }, "uid", "fromGroupId");
        }

        public void GroupDeleteUser()
        {

            var result = client.Group.DeleteUser(new[] { "groupId" }, "uid");
        }
    }
}