# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

``` yaml

azure-arm: true
csharp: true
library-name: Relay
namespace: Azure.ResourceManager.Relay
require: https://github.com/Azure/azure-rest-api-specs/tree/cc8796418bed73e7e3755d8a6a2d84abcb3ec7f4/specification/relay/resource-manager/readme.md
output-folder: $(this-folder)/Generated
clear-output-folder: true
skip-csproj: true
modelerfour:
  flatten-payloads: false

request-path-to-resource-name:
    /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/authorizationRules/{authorizationRuleName}: RelayNamespaceAuthorizationRule
    /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/hybridConnections/{hybridConnectionName}/authorizationRules/{authorizationRuleName}: RelayHybridConnectionAuthorizationRule
    /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}/wcfRelays/{relayName}/authorizationRules/{authorizationRuleName}: WcfRelayAuthorizationRule

override-operation-name:
  Namespaces_CheckNameAvailability: CheckRelayNamespaceNameAvailability

format-by-name-rules:
  'tenantId': 'uuid'
  'etag': 'etag'
  'location': 'azure-location'
  '*Uri': 'Uri'
  '*Uris': 'Uri'
 

rename-rules:
  CPU: Cpu
  CPUs: Cpus
  Os: OS
  Ip: IP
  Ips: IPs|ips
  ID: Id
  IDs: Ids
  VM: Vm
  VMs: Vms
  Vmos: VmOS
  VMScaleSet: VmScaleSet
  DNS: Dns
  VPN: Vpn
  NAT: Nat
  WAN: Wan
  Ipv4: IPv4|ipv4
  Ipv6: IPv6|ipv6
  Ipsec: IPsec|ipsec
  SSO: Sso
  URI: Uri
  Etag: ETag|etag

rename-mapping:
  AuthorizationRule: RelayAuthorizationRule
  AccessRights: RelayAccessRight
  HybridConnection.properties.requiresClientAuthorization: IsClientAuthorizationRequired
  AccessKeys: RelayAccessKeys
  RegenerateAccessKeyParameters: RelayRegenerateAccessKeyContent
  NetworkRuleSet: RelayNetworkRuleSet
  DefaultAction: RelayNetworkRuleSetDefaultAction
  NetworkRuleIPAction: RelayNetworkRuleIPAction
  PublicNetworkAccess: RelayPublicNetworkAccess
  ConnectionState: RelayPrivateLinkServiceConnectionState
  PrivateLinkConnectionStatus: RelayPrivateLinkConnectionStatus
  EndPointProvisioningState: RelayPrivateEndpointConnectionProvisioningState
  WcfRelay.properties.requiresClientAuthorization: IsClientAuthorizationRequired
  WcfRelay.properties.requiresTransportSecurity: IsTransportSecurityRequired
  Relaytype: RelayType
  CheckNameAvailability: RelayNameAvailabilityContent
  CheckNameAvailabilityResult: RelayNameAvailabilityResult
  CheckNameAvailabilityResult.nameAvailable: IsNameAvailable
  UnavailableReason: RelayNameUnavailableReason
  KeyType: RelayAccessKeyType
  HybridConnection: RelayHybridConnection

directive:
  from: NetworkRuleSets.json
  where: $.definitions
  transform: >
    $.NWRuleSetIpRules['x-ms-client-name'] = 'RelayNetworkRuleSetIPRule';
```
