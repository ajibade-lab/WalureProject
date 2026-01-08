variable "resource_group_name" {
  default = "rg-ajibadeapi"
}

variable "location" {
  default = "eastus2"
}

variable "aks_name" {
  default = "ajibadeapi-aks"
}

variable "acr_name" {
  default = "ajibadeapiacr123" # MUST be globally unique
}
