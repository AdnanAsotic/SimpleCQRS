using System;
using SimpleCqrs.Domain;

namespace SimpleCqrs.Eventing
{
    /// <summary>
    /// Neuer Kommentar
    /// </summary>
    public class NullSnapshotStore : ISnapshotStore
    {
        public Snapshot GetSnapshot(Guid aggregateRootId)
        {
            return null;
        }

        public void SaveSnapshot<TSnapshot>(TSnapshot snapshot) where TSnapshot : Snapshot
        {
        }
    }
}