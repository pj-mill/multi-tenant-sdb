namespace multi_tenant_sdb.Models
{
    public interface ITenant
    {
        public string TenantId { get; set; }
    }
}