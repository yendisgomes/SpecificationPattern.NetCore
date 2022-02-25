pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        echo 'Jenkins Pipeline'
      }
    }

    stage('error') {
      steps {
        bat 'dotnet restore'
        bat 'dotnet build'
      }
    }

  }
}