// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// ServiceSpec describes the attributes that a user creates on a service.
    /// </summary>
    public partial class V1ServiceSpec
    {
        /// <summary>
        /// Initializes a new instance of the V1ServiceSpec class.
        /// </summary>
        public V1ServiceSpec()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1ServiceSpec class.
        /// </summary>
        /// <param name="clusterIP">clusterIP is the IP address of the service
        /// and is usually assigned randomly by the master. If an address is
        /// specified manually and is not in use by others, it will be
        /// allocated to the service; otherwise, creation of the service will
        /// fail. This field can not be changed through updates. Valid values
        /// are "None", empty string (""), or a valid IP address. "None" can be
        /// specified for headless services when proxying is not required. Only
        /// applies to types ClusterIP, NodePort, and LoadBalancer. Ignored if
        /// type is ExternalName. More info:
        /// http://kubernetes.io/docs/user-guide/services#virtual-ips-and-service-proxies</param>
        /// <param name="deprecatedPublicIPs">deprecatedPublicIPs is deprecated
        /// and replaced by the externalIPs field with almost the exact same
        /// semantics.  This field is retained in the v1 API for compatibility
        /// until at least 8/20/2016.  It will be removed from any new API
        /// revisions.  If both deprecatedPublicIPs *and* externalIPs are set,
        /// deprecatedPublicIPs is used.</param>
        /// <param name="externalIPs">externalIPs is a list of IP addresses for
        /// which nodes in the cluster will also accept traffic for this
        /// service.  These IPs are not managed by Kubernetes.  The user is
        /// responsible for ensuring that traffic arrives at a node with this
        /// IP.  A common example is external load-balancers that are not part
        /// of the Kubernetes system.  A previous form of this functionality
        /// exists as the deprecatedPublicIPs field.  When using this field,
        /// callers should also clear the deprecatedPublicIPs field.</param>
        /// <param name="externalName">externalName is the external reference
        /// that kubedns or equivalent will return as a CNAME record for this
        /// service. No proxying will be involved. Must be a valid DNS name and
        /// requires Type to be ExternalName.</param>
        /// <param name="loadBalancerIP">Only applies to Service Type:
        /// LoadBalancer LoadBalancer will get created with the IP specified in
        /// this field. This feature depends on whether the underlying
        /// cloud-provider supports specifying the loadBalancerIP when a load
        /// balancer is created. This field will be ignored if the
        /// cloud-provider does not support the feature.</param>
        /// <param name="loadBalancerSourceRanges">If specified and supported
        /// by the platform, this will restrict traffic through the
        /// cloud-provider load-balancer will be restricted to the specified
        /// client IPs. This field will be ignored if the cloud-provider does
        /// not support the feature." More info:
        /// http://kubernetes.io/docs/user-guide/services-firewalls</param>
        /// <param name="ports">The list of ports that are exposed by this
        /// service. More info:
        /// http://kubernetes.io/docs/user-guide/services#virtual-ips-and-service-proxies</param>
        /// <param name="selector">Route service traffic to pods with label
        /// keys and values matching this selector. If empty or not present,
        /// the service is assumed to have an external process managing its
        /// endpoints, which Kubernetes will not modify. Only applies to types
        /// ClusterIP, NodePort, and LoadBalancer. Ignored if type is
        /// ExternalName. More info:
        /// http://kubernetes.io/docs/user-guide/services#overview</param>
        /// <param name="sessionAffinity">Supports "ClientIP" and "None". Used
        /// to maintain session affinity. Enable client IP based session
        /// affinity. Must be ClientIP or None. Defaults to None. More info:
        /// http://kubernetes.io/docs/user-guide/services#virtual-ips-and-service-proxies</param>
        /// <param name="type">type determines how the Service is exposed.
        /// Defaults to ClusterIP. Valid options are ExternalName, ClusterIP,
        /// NodePort, and LoadBalancer. "ExternalName" maps to the specified
        /// externalName. "ClusterIP" allocates a cluster-internal IP address
        /// for load-balancing to endpoints. Endpoints are determined by the
        /// selector or if that is not specified, by manual construction of an
        /// Endpoints object. If clusterIP is "None", no virtual IP is
        /// allocated and the endpoints are published as a set of endpoints
        /// rather than a stable IP. "NodePort" builds on ClusterIP and
        /// allocates a port on every node which routes to the clusterIP.
        /// "LoadBalancer" builds on NodePort and creates an external
        /// load-balancer (if supported in the current cloud) which routes to
        /// the clusterIP. More info:
        /// http://kubernetes.io/docs/user-guide/services#overview</param>
        public V1ServiceSpec(string clusterIP = default(string), IList<string> deprecatedPublicIPs = default(IList<string>), IList<string> externalIPs = default(IList<string>), string externalName = default(string), string loadBalancerIP = default(string), IList<string> loadBalancerSourceRanges = default(IList<string>), IList<V1ServicePort> ports = default(IList<V1ServicePort>), IDictionary<string, string> selector = default(IDictionary<string, string>), string sessionAffinity = default(string), string type = default(string))
        {
            ClusterIP = clusterIP;
            DeprecatedPublicIPs = deprecatedPublicIPs;
            ExternalIPs = externalIPs;
            ExternalName = externalName;
            LoadBalancerIP = loadBalancerIP;
            LoadBalancerSourceRanges = loadBalancerSourceRanges;
            Ports = ports;
            Selector = selector;
            SessionAffinity = sessionAffinity;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets clusterIP is the IP address of the service and is
        /// usually assigned randomly by the master. If an address is specified
        /// manually and is not in use by others, it will be allocated to the
        /// service; otherwise, creation of the service will fail. This field
        /// can not be changed through updates. Valid values are "None", empty
        /// string (""), or a valid IP address. "None" can be specified for
        /// headless services when proxying is not required. Only applies to
        /// types ClusterIP, NodePort, and LoadBalancer. Ignored if type is
        /// ExternalName. More info:
        /// http://kubernetes.io/docs/user-guide/services#virtual-ips-and-service-proxies
        /// </summary>
        [JsonProperty(PropertyName = "clusterIP")]
        public string ClusterIP { get; set; }

        /// <summary>
        /// Gets or sets deprecatedPublicIPs is deprecated and replaced by the
        /// externalIPs field with almost the exact same semantics.  This field
        /// is retained in the v1 API for compatibility until at least
        /// 8/20/2016.  It will be removed from any new API revisions.  If both
        /// deprecatedPublicIPs *and* externalIPs are set, deprecatedPublicIPs
        /// is used.
        /// </summary>
        [JsonProperty(PropertyName = "deprecatedPublicIPs")]
        public IList<string> DeprecatedPublicIPs { get; set; }

        /// <summary>
        /// Gets or sets externalIPs is a list of IP addresses for which nodes
        /// in the cluster will also accept traffic for this service.  These
        /// IPs are not managed by Kubernetes.  The user is responsible for
        /// ensuring that traffic arrives at a node with this IP.  A common
        /// example is external load-balancers that are not part of the
        /// Kubernetes system.  A previous form of this functionality exists as
        /// the deprecatedPublicIPs field.  When using this field, callers
        /// should also clear the deprecatedPublicIPs field.
        /// </summary>
        [JsonProperty(PropertyName = "externalIPs")]
        public IList<string> ExternalIPs { get; set; }

        /// <summary>
        /// Gets or sets externalName is the external reference that kubedns or
        /// equivalent will return as a CNAME record for this service. No
        /// proxying will be involved. Must be a valid DNS name and requires
        /// Type to be ExternalName.
        /// </summary>
        [JsonProperty(PropertyName = "externalName")]
        public string ExternalName { get; set; }

        /// <summary>
        /// Gets or sets only applies to Service Type: LoadBalancer
        /// LoadBalancer will get created with the IP specified in this field.
        /// This feature depends on whether the underlying cloud-provider
        /// supports specifying the loadBalancerIP when a load balancer is
        /// created. This field will be ignored if the cloud-provider does not
        /// support the feature.
        /// </summary>
        [JsonProperty(PropertyName = "loadBalancerIP")]
        public string LoadBalancerIP { get; set; }

        /// <summary>
        /// Gets or sets if specified and supported by the platform, this will
        /// restrict traffic through the cloud-provider load-balancer will be
        /// restricted to the specified client IPs. This field will be ignored
        /// if the cloud-provider does not support the feature." More info:
        /// http://kubernetes.io/docs/user-guide/services-firewalls
        /// </summary>
        [JsonProperty(PropertyName = "loadBalancerSourceRanges")]
        public IList<string> LoadBalancerSourceRanges { get; set; }

        /// <summary>
        /// Gets or sets the list of ports that are exposed by this service.
        /// More info:
        /// http://kubernetes.io/docs/user-guide/services#virtual-ips-and-service-proxies
        /// </summary>
        [JsonProperty(PropertyName = "ports")]
        public IList<V1ServicePort> Ports { get; set; }

        /// <summary>
        /// Gets or sets route service traffic to pods with label keys and
        /// values matching this selector. If empty or not present, the service
        /// is assumed to have an external process managing its endpoints,
        /// which Kubernetes will not modify. Only applies to types ClusterIP,
        /// NodePort, and LoadBalancer. Ignored if type is ExternalName. More
        /// info: http://kubernetes.io/docs/user-guide/services#overview
        /// </summary>
        [JsonProperty(PropertyName = "selector")]
        public IDictionary<string, string> Selector { get; set; }

        /// <summary>
        /// Gets or sets supports "ClientIP" and "None". Used to maintain
        /// session affinity. Enable client IP based session affinity. Must be
        /// ClientIP or None. Defaults to None. More info:
        /// http://kubernetes.io/docs/user-guide/services#virtual-ips-and-service-proxies
        /// </summary>
        [JsonProperty(PropertyName = "sessionAffinity")]
        public string SessionAffinity { get; set; }

        /// <summary>
        /// Gets or sets type determines how the Service is exposed. Defaults
        /// to ClusterIP. Valid options are ExternalName, ClusterIP, NodePort,
        /// and LoadBalancer. "ExternalName" maps to the specified
        /// externalName. "ClusterIP" allocates a cluster-internal IP address
        /// for load-balancing to endpoints. Endpoints are determined by the
        /// selector or if that is not specified, by manual construction of an
        /// Endpoints object. If clusterIP is "None", no virtual IP is
        /// allocated and the endpoints are published as a set of endpoints
        /// rather than a stable IP. "NodePort" builds on ClusterIP and
        /// allocates a port on every node which routes to the clusterIP.
        /// "LoadBalancer" builds on NodePort and creates an external
        /// load-balancer (if supported in the current cloud) which routes to
        /// the clusterIP. More info:
        /// http://kubernetes.io/docs/user-guide/services#overview
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}