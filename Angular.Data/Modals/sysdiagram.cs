#region

using Angular.Data.Modals.Base;

#endregion



namespace Angular.Data.Modals
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