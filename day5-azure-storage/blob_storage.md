# Azure storage
- blob storage
- file storage
- table storage
- queue storage
- disk storage


## Storage Account
### Type
1. General-purpose v2(GPV2) 
supports : all
performace : stnadard and premiuum tier
replication : all replication options
access tier : hot, cool, archive

2. block blob
Supports: Block blobs and append blobs only
Performance: Premium (SSD-based)
Replication: LRS and ZRS only
Use Case: High transaction rates, low latency scenarios

3. FileStorage - Premium
Supports: File shares only
Performance: Premium (SSD-based)
Replication: LRS and ZRS only
Use Case: High-performance file shares

4. page blob
Supports: random read/write access 
Performance: Premium
Replication: X
Use Case: Azure VM disks, databases


### Performance tier
1. premium
2. standard 

### Replication options
1. Locally redundant stroage : 3 copies within single data center
2. zone redundant storage : 3 copies across availability zones
3. Geo-Redundant Storage (GRS) : 6 copies (3 local + 3 in paired region)
4. Geo-Zone-Redundant Storage (GZRS)

### Access tier
1. hot tier
2. cool tier - 30 days minimum duration
3. archive tier - 180 days minimum duration

### Blob lifecycle management

