# mre_ef
This repo shows problem for EF 5.0.5 with SQL Server provider when:
- Owned entity type is used
- the owned type has property with an Id suffix

This error appears:
```The keys {'BarId'} on 'BarUniqueId' and {'Id'} on 'Bar' are both mapped to 'Bars.PK_Bars' but with different columns ({'BarId'} and {'Id'}).```

although ValueGeneratedNever is applied

Note:
- chaging BarUniqueId.BarId -> BarUniqueId.BarId*k* SOLVES the problem
- chaging BarUniqueId -> BarUniqueId*k* DOESN'T solve the problem
- DOESN'T happen with InMemory provider so reproducible with SQL Server
- EF 5.0 on .NET5.0 has the same problem as shown on [this branch](/lutofcaku/mre_ef/tree/ef-5.0)

