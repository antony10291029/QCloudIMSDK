腾讯云IM的C#实现


           QCloudIMv4.CreateGroup(new CreateGroupRequest()
            {
                Name = "TestGroup",
                Type = "Public",
            });

            var result = QCloudIMv4.DestroyGroup(new DestroyGroupRequest()
            {
                GroupId = "id值"
            });
            
