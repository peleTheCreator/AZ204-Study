# Azure Container Registry?
- ACR is a managed Docker registry service for storing and managing private container images and related artifacts.

## Key Features:
Geo-replication: Replicate images across regions
Security: Private registry with RBAC and network isolation
CI/CD Integration: Webhooks and task automation
Vulnerability Scanning: Built-in security scanning
Helm Chart Support: Store Helm charts alongside images

## ACR Service Tiers:
### Basic Tier
Storage: 10 GB included
Throughput: 10 operations/min
Webhooks: 2
Geo-replication: ❌
Best For: Development and testing

### Standard Tier
Storage: 100 GB included
Throughput: 100 operations/min
Webhooks: 10
Geo-replication: ❌
Best For: Production workloads

### Premium Tier
Storage: 500 GB included
Throughput: 500 operations/min
Webhooks: 500
Geo-replication: ✅
Content Trust: ✅
Private Link: ✅
Best For: High-scale production, enterprise security


--- 
## 
### Azure Container Instances What is Azure Container Instances?
ACI is a serverless container platform that allows you to run containers without managing servers or orchestrators.

### Key Benefits:
Serverless: No infrastructure management
Fast Startup: Containers start in seconds
Per-second Billing: Pay only for execution time
Flexible Sizing: Custom CPU and memory allocation
Persistent Storage: Mount Azure Files shares
Network Integration: VNET integration available

### ACI Use Cases:
Build Agents: CI/CD pipeline workers
Batch Processing: One-time or scheduled tasks
Development/Testing: Temporary environments
Event-driven Scaling: Scale out App Service or AKS
API Services: Lightweight microservices

### Container Groups
Container groups are collections of containers that get scheduled on the same host machine and share lifecycle, resources, local network, and storage volumes.

### Container Group Benefits:
Shared Resources: CPU, memory, and storage
Shared Network: Containers can communicate via localhost
Shared Lifecycle: Start, stop, and delete together
Sidecar Patterns: Logging, monitoring, proxy containers

---- 

# Kubernetes Fundamentals
What is Kubernetes?
Kubernetes is an open-source container orchestration platform that automates deployment, scaling, and management of containerized applications.

## Core Kubernetes Concepts:
### Pod
Smallest deployable unit in Kubernetes
Contains one or more containers
Containers in a pod share network and storage
Pods are ephemeral and replaceable

### Node
Worker machine in Kubernetes cluster
Runs kubelet, kube-proxy, and container runtime
Can be physical or virtual machine

### Cluster
Set of nodes that run containerized applications
Includes master node(s) and worker nodes


## Deployment
Manages replica sets and pod updates
Provides declarative updates for pods
Ensures desired number of replicas

## Service
Stable network endpoint for pods
Load balances traffic across pods
Types: ClusterIP, NodePort, LoadBalancer

## Namespace
Virtual cluster within physical cluster
Provides scope for names and resources
Used for multi-tenancy and resource isolation

## Kubernetes Architecture
### Master Node Components:
API Server: Frontend for Kubernetes API
etcd: Distributed key-value store for cluster data
Scheduler: Assigns pods to nodes
Controller Manager: Runs controller processes

### Worker Node Components:
kubelet: Ensures containers are running in pods
kube-proxy: Network proxy and load balancer
Container Runtime: Docker, containerd, CRI-O

### YAML Configuration Basics
Pod Definition:
yamlapiVersion: v1
kind: Pod
metadata:
  name: my-pod
  labels:
    app: my-app
spec:
  containers:
  - name: my-container
    image: nginx:1.20
    ports:
    - containerPort: 80
    resources:
      requests:
        cpu: 100m
        memory: 128Mi
      limits:
        cpu: 500m
        memory: 512Mi
### Deployment Definition:
yamlapiVersion: apps/v1
kind: Deployment
metadata:
  name: my-deployment
  labels:
    app: my-app
spec:
  replicas: 3
  selector:
    matchLabels:
      app: my-app
  template:
    metadata:
      labels:
        app: my-app
    spec:
      containers:
      - name: my-container
        image: nginx:1.20
        ports:
        - containerPort: 80
        env:
        - name: ENV_VAR
          value: "production"
### Service Definition:
yamlapiVersion: v1
kind: Service
metadata:
  name: my-service
spec:
  selector:
    app: my-app
  ports:
  - protocol: TCP
    port: 80
    targetPort: 80
  type: LoadBalancer


  ----
# What is Azure Kubernetes Service?
AKS is a managed Kubernetes service that simplifies deploying and managing Kubernetes clusters in Azure.
## AKS Benefits:

Managed Master: Azure manages Kubernetes master nodes
Auto-scaling: Cluster and pod auto-scaling
Security: Integration with Azure AD and RBAC
Monitoring: Built-in monitoring with Azure Monitor
Networking: Advanced networking options
Storage: Integration with Azure storage services


##  AKS Cluster Types:
- Development Cluster
Node Count: 1-3 nodes
VM Size: Standard_B2s or similar
Networking: Basic networking
Cost: Low cost for development/testing

- Production Cluster
Node Count: 3+ nodes across availability zones
VM Size: Standard_D4s_v3 or higher
Networking: Azure CNI with advanced networking
High Availability: Multiple node pools