using System;

namespace VersionAttribute
{
    /// <summary>
    /// Version Atrribute Class
    /// </summary>
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
    public class VersionAttribute : Attribute
    {
        public VersionAttribute(string version)
        {
            this.Version = version;
        }
        public string Version { get; set; }
    }
}