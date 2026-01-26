# 🚀 Walure Cloud-Native DevOps Project — Push-to-Deploy Architecture

[![Build Status](https://img.shields.io/github/actions/workflow/status/ajibade-lab/WalureProject/ci.yml?style=for-the-badge)](#)
[![Docker](https://img.shields.io/badge/Docker-Ready-blue?style=for-the-badge&logo=docker)](#)
[![Kubernetes](https://img.shields.io/badge/Kubernetes-Orchestrated-blueviolet?style=for-the-badge&logo=kubernetes)](#)
[![Azure](https://img.shields.io/badge/Microsoft_Azure-Cloud_Infra-0078D4?style=for-the-badge&logo=microsoftazure)](#)

> **A fully automated DevOps pipeline implementing GitOps-driven Kubernetes deployments using Terraform, GitHub Actions, Docker, ArgoCD, Prometheus & Grafana.**

---

## 📚 Academic Project Information

| Role              | Details                    |
| ----------------- | -------------------------- |
| **Student Name**  | **Apata Sulaimon Ajibade** |
| **Project Tutor** | **Prolific Lexzy**         |
| **Institution**   | **Walure Academy**         |

---

## 🌍 Live Application Access

**Application URL:**

```
http://<MINIKUBE-IP>:<NODE-PORT>
```

Example:

```
http://192.168.49.2:30121
```

> ⚠️ The IP and port will be generated automatically by Minikube using:

```bash
minikube service ajibadeapi-service
```

---

## 🧠 Project Overview

This project implements a **real‑world DevOps pipeline** using modern **cloud‑native and GitOps principles**. The system automates the full lifecycle of application deployment — from **code commit to production release**.

### 🎯 Key Objectives:
- Build a scalable **.NET API**
- Containerize using **Docker**
- Provision infrastructure using **Terraform**
- Deploy to **Kubernetes (AKS / Minikube)**
- Implement **CI/CD pipelines with GitHub Actions**
- Enable **GitOps deployment using ArgoCD**
- Add **Monitoring with Prometheus & Grafana**

---

## 🏗 System Architecture

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

## 🔧 Technology Stack

| **Layer**          | **Tools**                   |
| ------------------ | --------------------------- |
| Backend API        | ASP.NET Core (.NET)         |
| Containerization   | Docker                      |
| Infrastrusture     | Terraform                   |
| CI/CD              | GitHub Actions              |
| Container Registry | Docker Hub                  |
| Orchestration      | Kubernetes (Minikube / AKS) |
| GitOps CD          | Argo CD                     |
| Monitoring         | Prometheus + Grafana        |
| Cloud Platform     | Microsoft Azure (Optional)  |

---

## ⚙️ How It Works (DevOps Workflow)

### 🔹 Step 1 — Code Commit
Developers push code to GitHub.

### 🔹 Step 2 — CI Pipeline (GitHub Actions)
GitHub Actions automatically:
- Build Docker Image
- Push image to Docker Hub / Azure ACR
- Automatically update Kubernetes manifests

### 🔹 Step 3 — GitOps Deployment (ArgoCD)
Argo CD monitors the `manifests/` directory and automatically:
- Syncs new changes 
- Deploys updates to Kubernetes
- Ensures desired state is always maintained

### 🔹 Step 4 — Monitoring
- Prometheus scrapes metrics
- Grafana visualizes performance dashboards

---

## 🚀 How To Use The Application

### Get Service URL

```bash
minikube service ajibadeapi-service
```

### 🔹Access Swagger API Interface

```
http://<APP_URL>/swagger
```

Swagger provides:

* API documentation
* Interactive testing interface
* Request/response previews

---

### 🔹Sample API Test

```bash
curl http://<APP_URL>/api/health
```

Expected Output:

```json
{
  "status": "Healthy",
  "service": "ajibadeapi"
}
```

---

## 🛠 Local Development Setup

### Prerequisites

```bash
Docker
Minikube / AKS
Terraform
kubectl
Git
```

---

### Clone Repository

```bash
git clone https://github.com/ajibade-lab/WalureProject.git
cd WalureProject
```

---

### Build Docker Image

```bash
docker build -t ajibadeapi:latest
```

---

### Deploy to Kubernetes

```bash
kubectl apply -f manifests/ajibadeapi
```

---

## 📊 Monitoring Setup

```bash
kubectl create namespace monitoring
helm install prometheus prometheus-community/kube-prometheus-stack -n monitoring
```

Access Grafana:

```bash
kubectl port-forward svc/prometheus-grafana -n monitoring 3000:80
```

Open:

```
http://<GRAFANA_URL>:3000
```

Login:

```
Username: admin
Password: admin
```

View:

```
CPU usage
Memory utilization
API response time
Pod health
```


---

## 🔐 Security Practices

* Secrets managed using GitHub Secrets
* Token‑based Docker authentication
* Secure CI/CD isolation
* Kubernetes RBAC access control

---

## 🎓 Learning Outcomes

This project demonstrates mastery of:

* Cloud‑native DevOps engineering
* CI/CD automation
* Kubernetes orchestration
* GitOps deployment workflows
* Observability & monitoring
* Infrastructure‑as‑Code principles

---

## 🏆 Academic Context

This project was developed at **Walure Academy** under the mentorship of **Prolific Lexzy** as a **professional DevOps engineering capstone project**.

It demonstrates **production‑grade system design, automation, and deployment strategies** used in modern cloud organizations.

---

## 👨‍💻 Author

**Apata Sulaimon Ajibade**

Cloud & DevOps Engineer

---

## ⭐ Project Status

```
🟢 PRODUCTION READY
```

---

## 📜 License

This project is licensed for **academic, educational, and research purposes only**.

---

> "Automation is the heart of DevOps excellence." 🚀
