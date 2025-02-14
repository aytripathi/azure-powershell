---
external help file: Az.DataProtection-help.xml
Module Name: Az.DataProtection
online version: https://learn.microsoft.com/powershell/module/az.dataprotection/search-azdataprotectionbackupvaultinazgraph
schema: 2.0.0
---

# Search-AzDataProtectionBackupVaultInAzGraph

## SYNOPSIS
Searches for Backup vaults in Azure Resource Graph and retrieves the expected entries

## SYNTAX

```
Search-AzDataProtectionBackupVaultInAzGraph -Subscription <String[]> [-ResourceGroup <String[]>]
 [-Vault <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

## DESCRIPTION
Searches for Backup vaults in Azure Resource Graph and retrieves the expected entries

## EXAMPLES

### EXAMPLE 1
```
Search-AzDataProtectionBackupVaultInAzGraph -Subscription "xxxxxxxx-xxxx-xxxxxxxxxxxx" -ResourceGroup $resourceGroupName -Vault $vaultName
```

## PARAMETERS

### -DefaultProfile
{{ Fill DefaultProfile Description }}

```yaml
Type: PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroup
Resource Group of Vault

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Subscription
Subscription of Vault

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Vault
Name of the vault

```yaml
Type: String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### System.Management.Automation.PSObject
## NOTES

## RELATED LINKS

[https://learn.microsoft.com/powershell/module/az.dataprotection/search-azdataprotectionbackupvaultinazgraph](https://learn.microsoft.com/powershell/module/az.dataprotection/search-azdataprotectionbackupvaultinazgraph)

