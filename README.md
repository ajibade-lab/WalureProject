# Walure Cloud-Native DevOps Project — Push-to-Deploy Architecture

[![Build Status](https://img.shields.io/github/actions/workflow/status/ajibade-lab/WalureProject/ci.yml?style=for-the-badge)](#)
[![Docker](https://img.shields.io/badge/Docker-Ready-blue?style=for-the-badge&logo=docker)](#)
[![Kubernetes](https://img.shields.io/badge/Kubernetes-Orchestrated-blueviolet?style=for-the-badge&logo=kubernetes)](#)
[![Azure](https://img.shields.io/badge/Microsoft_Azure-Cloud_Infra-0078D4?style=for-the-badge&logo=microsoftazure)](#)

> **A fully automated DevOps pipeline implementing GitOps-driven Kubernetes deployments using Terraform, GitHub Actions, Docker, ArgoCD, Prometheus & Grafana.**

---

## Academic Project Information

| Role              | Details                    |
| ----------------- | -------------------------- |
| **Student Name**  | **Ajibade Apata**          |
| **Project Tutor** | **Ifeanyi**         |
| **Institution**   | **Walure Academy**         |

 Download the full technical presentation of this project: **[Download Project Slides (.pptx)](docs/Ajibade_DevOps_Project.pptx)**

---

## Project Overview

This project demonstrates a **production‑grade, cloud‑native DevOps pipeline** implemented on **Microsoft Azure**, following modern **CI/CD and GitOps best practices**. The objective of the project is to design, build, deploy, and monitor a containerized **ASP.NET Core Web API** using a fully automated workflow — from source code commit to deployment and observability in Kubernetes.

The solution integrates **Infrastructure as Code (IaC)**, **Continuous Integration (CI)**, **Continuous Deployment (CD)**, **GitOps**, and **Observability** into a single cohesive system that mirrors real‑world enterprise DevOps environments.


## Architecture Summary

The architecture follows a **Push‑to‑Deploy GitOps model**:

1. **Developer** pushes code to GitHub
2. **GitHub Actions (CI)** builds and containerizes the application
3. Docker image is pushed to **Azure Container Registry (ACR) / DockerHub**
4. **Argo CD** continuously watches Kubernetes manifests stored in GitHub
5. **Azure Kubernetes Service (AKS)** pulls the image and deploys the application
6. **Prometheus** collects metrics from the application and cluster
7. **Grafana** visualizes metrics for monitoring and observability

GitHub acts as the **single source of truth** for both application code and Kubernetes configuration.

---

## Project Architecture

```
Developer → GitHub → GitHub Actions → Docker Hub
                                ↓
                            Kubernetes
                                ↓
                          Argo CD (GitOps)
                                ↓
                          Live Application
                                ↓
                        Prometheus → Grafana
```

---

##  Application Layer

### Technology Stack

* **ASP.NET Core Web API (.NET 8)**
* **Docker** for containerization
* Stateless REST API design

### Application Features

* Root endpoint (`/`) for service verification
* Health endpoint (`/health`) for Kubernetes probes
* Metrics endpoint (`/metrics`) for Prometheus scraping

### Key Command (Create App)

```bash
dotnet new webapi -n ajibadeapi
dotnet run
```

---

## Containerization with Docker

The application is packaged using a **multi‑stage Docker build**, ensuring a lightweight and secure runtime image.

### Key Benefits

* Smaller image size
* Faster deployments
* Clear separation between build and runtime environments

### Key Commands

```bash
docker build -t ajibadeapi:latest .
docker run -p 8080:8080 ajibadeapi:latest
```

---

## Infrastructure as Code (Terraform)

All cloud resources are provisioned using **Terraform**, ensuring repeatable, version‑controlled infrastructure.

### Azure Resources Provisioned

* Resource Group
* Azure Kubernetes Service (AKS)
* Azure Container Registry (ACR) / DockerHub
* Role assignment (`AcrPull`) between AKS and ACR

### Key Terraform Commands

```bash
terraform init
terraform plan
terraform apply
```

### Benefits

* No manual cloud setup
* Infrastructure consistency
* Easy teardown and recreation

---

## Continuous Integration (GitHub Actions)

GitHub Actions is used to automate the **build and containerization process**.

### CI Pipeline Responsibilities

* Triggered on every push to `main`
* Builds the .NET application
* Builds Docker image
* Pushes image to Azure Container Registry

### Key Git Commands

```bash
git add .
git commit -m "Trigger CI pipeline"
git push origin main
```

This guarantees that every code change produces a new container image automatically.

---

## Container Registry (ACR)

Azure Container Registry stores versioned Docker images securely and acts as the deployment source for AKS.

### Key Commands

```bash
az acr login --name <acr-name>
docker push <acr-login-server>/ajibadeapi:latest
```

AKS is granted permission to pull images using Azure role‑based access control (RBAC).

---

## Continuous Deployment with GitOps (Argo CD)

### GitOps Model

* Kubernetes manifests are stored in GitHub
* Git is the single source of truth
* Argo CD continuously reconciles cluster state

### Argo CD Responsibilities

* Watches the GitHub repository
* Deploys and updates Kubernetes manifests
* Automatically self‑heals configuration drift

### Key Commands

```bash
kubectl create namespace argocd
kubectl apply -n argocd -f https://raw.githubusercontent.com/argoproj/argo-cd/stable/manifests/install.yaml
```

---

## Automatic Image Updates

To eliminate manual image version updates, **Argo CD Image Updater** is integrated.

### How It Works

* Detects new images in ACR
* Updates Kubernetes manifests in GitHub
* Triggers automatic redeployment

### Benefits

* Zero manual intervention
* True continuous delivery
* Strong GitOps compliance

---

## Kubernetes Deployment

The application is deployed to AKS using declarative YAML manifests.

### Kubernetes Objects Used

* Deployment
* Service (NodePort)

### Key Commands

```bash
kubectl apply -f manifests/
kubectl get pods
kubectl get svc
```

The service exposes the application publicly using Node-Port.

---

## Observability (Prometheus & Grafana)

### Prometheus

* Scrapes metrics from the application and cluster
* Collects CPU, memory, request, and latency metrics

### Grafana

* Visualizes metrics via dashboards
* Enables real‑time monitoring and performance analysis

### Key Commands

```bash
helm install prometheus prometheus-community/prometheus -n monitoring
helm install grafana grafana/grafana -n monitoring
```

---

## Live Application Access

**Application URL:**

```
http://<MINIKUBE-IP>:<NODE-PORT>
```

Example:

```
http://192.168.49.2:30121
```

> The IP and port will be generated automatically by Minikube using:

```bash
minikube service ajibadeapi-service
```

---


## DevOps Best Practices Implemented

* Infrastructure as Code (Terraform)
* CI automation with GitHub Actions
* GitOps‑based CD using Argo CD
* Containerization with Docker
* Kubernetes orchestration with AKS
* Automated image updates
* Full observability and monitoring

---

## Conclusion

This project successfully demonstrates an **end‑to‑end DevOps lifecycle** using modern cloud‑native tools. It highlights how automation, GitOps, and observability work together to create a scalable, reliable, and production‑ready deployment pipeline.

The architecture and tooling used in this project align closely with **real‑world enterprise DevOps practices**, making it a strong reference implementation for modern cloud deployments.

---

## Academic Context

This project was developed at **Walure Academy** under the mentorship of **Ifeanyi** as a **professional DevOps engineering capstone project**.

It demonstrates **production‑grade system design, automation, and deployment strategies** used in modern cloud organizations.

---

## License

This project is licensed for **academic, educational, and research purposes only**.

---

> "Automation is the heart of DevOps excellence." 
