# WalureProject
# 🚀 Walure Cloud-Native DevOps Project — Push-to-Deploy Architecture

[![Build Status](https://img.shields.io/github/actions/workflow/status/ajibade-lab/WalureProject/ci.yml?style=for-the-badge)](#)
[![Docker](https://img.shields.io/badge/Docker-Ready-blue?style=for-the-badge&logo=docker)](#)
[![Kubernetes](https://img.shields.io/badge/Kubernetes-Orchestrated-blueviolet?style=for-the-badge&logo=kubernetes)](#)
[![Azure](https://img.shields.io/badge/Microsoft_Azure-Cloud_Infra-0078D4?style=for-the-badge&logo=microsoftazure)](#)

> **A fully automated DevOps pipeline implementing GitOps-driven Kubernetes deployments using Terraform, GitHub Actions, Docker, ArgoCD, Prometheus & Grafana.**

---

## 📚 Academic Project Information

| Role | Name |
|--------|------|
| **Student** | **Apata Sulaimon Ajibade** |
| **Project Tutor** | **Prolific Lexzy** |
| **Institution** | **Walure Academy** |

---

## 🌐 Live Application Access

**Application URL:**  
http://<YOUR-CLUSTER-IP>:<NODE-PORT>


> ⚠️ Replace this with your **public LoadBalancer / Ingress URL** once deployed to production.

---

## 🧠 Project Overview

This project implements a **complete enterprise-grade DevOps workflow** using modern cloud-native technologies.

### 🎯 Key Objectives:
- Build a scalable **.NET API**
- Containerize using **Docker**
- Provision infrastructure using **Terraform**
- Deploy to **Kubernetes (AKS / Minikube)**
- Implement **CI/CD pipelines with GitHub Actions**
- Enable **GitOps deployment using ArgoCD**
- Add **Monitoring with Prometheus & Grafana**

---

## 🏗 Architecture Diagram

Developer → GitHub → GitHub Actions → Docker Hub / ACR
↓
Kubernetes Cluster
↓
ArgoCD (GitOps)
↓
Live Application
↓
Prometheus → Grafana


---

## 🔧 Technology Stack

| Layer | Tools |
|--------|-------|
| Backend API | ASP.NET Core |
| Containerization | Docker |
| Infrastructure | Terraform |
| CI/CD | GitHub Actions |
| Container Registry | Docker Hub / Azure ACR |
| Orchestration | Kubernetes |
| GitOps | Argo CD |
| Monitoring | Prometheus & Grafana |
| Cloud | Microsoft Azure |

---

## ⚙️ How It Works (DevOps Workflow)

### 🔹 Step 1 — Code Commit
Developers push code to GitHub.

### 🔹 Step 2 — CI Pipeline (GitHub Actions)
- Build Docker Image
- Push image to Docker Hub / Azure ACR
- Automatically update Kubernetes manifests

### 🔹 Step 3 — GitOps Deployment (ArgoCD)
- ArgoCD watches `manifests/`
- Auto-syncs new deployments to Kubernetes

### 🔹 Step 4 — Monitoring
- Prometheus scrapes metrics
- Grafana visualizes performance dashboards

---

## 🚀 How To Use The Application

### 1️⃣ Access the API

Open your browser and navigate to:
http://<APP_URL>/swagger


This opens **Swagger UI**, where you can:
- View endpoints
- Test API calls
- Send HTTP requests directly

---

### 2️⃣ Sample API Request

```bash
curl http://<APP_URL>/api/health

Expected Response:

{
  "status": "Healthy",
  "service": "Ajibade API"
}

Open Grafana dashboard:

http://<GRAFANA_URL>:3000


Login:

Username: admin
Password: admin


View:

CPU usage

Memory utilization

API response time

Pod health

Prerequisites
Docker
Kubectl
Terraform
Minikube / AKS
Git

Clone Repository
git clone https://github.com/ajibade-lab/WalureProject.git
cd WalureProject

Build Docker Image
docker build -t ajibadeapi .

Deploy to Kubernetes
kubectl apply -f manifests/

📊 Monitoring Stack Installation
kubectl create namespace monitoring
helm install prometheus prometheus-community/kube-prometheus-stack -n monitoring

🔐 CI/CD Security Design

GitHub Secrets for credentials

Docker registry authentication tokens

Secure pipeline isolation

Role-based Kubernetes access

🎓 Learning Outcomes

This project demonstrates mastery of:

✅ Cloud Infrastructure Engineering
✅ Kubernetes Orchestration
✅ GitOps Workflow
✅ DevOps Automation
✅ Monitoring & Observability
✅ Enterprise CI/CD Pipelines

🏆 Academic Purpose

This project was developed as part of Walure Academy's advanced DevOps engineering program under the mentorship of Prolific Lexzy, showcasing real-world industry deployment patterns.

👨‍💻 Author

Apata Sulaimon Ajibade
DevOps Engineer | Cloud Engineer | Kubernetes Specialist

📜 License

This project is licensed for educational and academic use only.

⭐ Project Status
🟢 PRODUCTION READY

🤝 Acknowledgements

Special thanks to:

🎓 Walure Academy
🧠 Prolific Lexzy
🌍 Open Source Community
