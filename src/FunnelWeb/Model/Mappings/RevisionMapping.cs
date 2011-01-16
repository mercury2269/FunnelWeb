using FluentNHibernate.Mapping;

namespace FunnelWeb.Model.Mappings
{
    public class RevisionMapping : ClassMap<Revision>
    {
        public RevisionMapping()
        {
            Id(x => x.Id);
            Map(x => x.Body);
            Map(x => x.ChangeSummary);
            Map(x => x.IsVisible);
            Map(x => x.Reason);
            Map(x => x.Revised);
            Map(x => x.RevisionNumber);
            Map(x => x.Status);
            Map(x => x.Tags);
            Map(x => x.Format);
            References(x => x.Entry, "EntryId");
        }
    }
}