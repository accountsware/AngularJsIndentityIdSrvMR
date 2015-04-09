#region

using AngularJs.Core.Modals.Base;

#endregion



namespace AngularJs.Core.Modals
{
    public class sysdiagram : Entity
    {
        public string name { get; set; }
        public int principal_id { get; set; }
        public int diagram_id { get; set; }
        public int? version { get; set; }
        public byte[] definition { get; set; }
    }
}