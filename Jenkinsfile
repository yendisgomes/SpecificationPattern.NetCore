pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        echo 'Jenkins Pipeline'
      }
    }

    stage('') {
      steps {
        sh 'dotnet restore'
        sh 'dotnet build'
      }
    }

  }
}