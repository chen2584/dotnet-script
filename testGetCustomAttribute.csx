var rootPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var filePath = Path.Combine(rootPath, "MassiveDelete.dll");
            var assembly = Assembly.Load(AssemblyName.GetAssemblyName(filePath));

            var methods = assembly.GetTypes()
                        .SelectMany(x => x.GetMethods())
                        .Where(m => m.GetCustomAttribute(typeof(ChenAttribute)) != null)
                    //   .GetMethods()
                    //   .Select(m => )
                      .ToArray();
            foreach (var method in methods)
            {
                Console.WriteLine(method.Name);
            }