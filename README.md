# mre_ef
This repo shows problem when:
- Owned entity type is used
- the owned type has property with an Id suffix

This error appears:
```The properties 'Bar.Id', 'BarUniqueId.BarId' are configured to use 'Identity' value generator and are mapped to the same table 'Bars'. Only one column per table can be configured as 'Identity'. Call 'ValueGeneratedNever' for properties that should not use 'Identity'.```

although ValueGeneratedNever is applied

Note:
- chaging BarUniqueId.BarId -> BarUniqueId.BarId*k* SOLVES the problem
- chaging BarUniqueId -> BarUniqueId*k* DOESN'T solve the problem
