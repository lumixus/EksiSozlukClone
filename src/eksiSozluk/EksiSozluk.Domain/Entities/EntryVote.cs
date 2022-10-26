﻿using System.Xml;
using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace EksiSozluk.Domain.Entities;

public class EntryVote:Entity
{
    public int EntryId { get; set; }
    public int WriterId { get; set; }
    // public VoteType VoteType { get; set; }
    public bool IsUpVote { get; set; }
    public virtual Entry Entry { get; set; }
    public virtual Writer Writer { get; set; }
}