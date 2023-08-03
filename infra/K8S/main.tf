provider "kubernetes" {
  config_path    = "C:/Users/biel-/.kube/config"
  config_context = "docker-desktop"
}

resource "kubernetes_namespace" "example" {
  metadata {
    name = "my-first-namespace"
  }
}