using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Durur.Modules.DataAccess.MigrateSeeds
{
    public static class MigrationUtility
    {
        /// <summary>
        /// Read a SQL script that is embedded into a resource.
        /// </summary>
        /// <param name="migrationType">The migration type the SQL file script is attached to.</param>
        /// <param name="sqlFileName">The embedded SQL file name.</param>
        /// <returns>The content of the SQL file.</returns>
        public static string ReadSql(Type migrationType, string sqlFileName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            string resourceName = $"{typeof(MigrationUtility).Namespace}.{sqlFileName}";
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    throw new FileNotFoundException("Unable to find the SQL file from an embedded resource", resourceName);
                }

                using (var reader = new StreamReader(stream))
                {
                    string content = reader.ReadToEnd();
                    return content;
                }
            }
        }
    }
}
