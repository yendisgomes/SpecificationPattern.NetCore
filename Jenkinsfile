pipeline {
  agent any
  
  stages {
    stage ('Clean workspace') {
      steps {
        cleanWs()
      }
    }

    stage ('Git Checkout') {
      steps {
      git branch: 'main', credentialsId: 'admin123', url: 'https://github.com/yendisgomes/SpecificationPattern.NetCore.git'
     }
    }
    
    stage('Restore packages') {
      steps {
      bat "dotnet restore ${workspace}\\SpecificationPattern.NetCore\\SpecificationPattern.NetCore.sln"
      }
    }
    
    stage('Clean') {
      steps {
      bat "msbuild.exe ${workspace}\\SpecificationPattern.NetCore\\SpecificationPattern.NetCore.sln" /nologo /nr:false /p:platform=\"x64\" /p:configuration=\"release\" /t:clean"
      }
    }
  
}