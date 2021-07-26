

pipeline {
    
    agent any
    
    stage{
       
   
        
        stage('Git clone Appsource code') {
            steps {
                git credentialsId: '4f90e1bb-2653-447a-a345-4b28df60b37c', poll: true, url: 'https://github.com/sangeetha-partha/AppSourcecode/'
                
            }
        }
        
   
        
      stage('Git clone Test Automation suite') {
            steps {
                sh '''ssh -T -v \'1972001@10.10.196.130\' /home/1972001/copy.sh'''
                sh '''ssh -T -v \'1972001@10.10.196.130\' /home/1972001/Extractsourcecode.sh'''
                sh '''ssh -T -v \'1972001@10.10.196.130\' /home/1972001/removesourcecode.sh'''
                
            }
        }
       
       stage('Build Source code') {
            steps {
                sh '''ssh -T -v \'1972001@10.10.196.130\' /home/1972001/sourcecodebuild.sh'''
                
            }
        }
        stage('Build Test Automation suite')
        {   
            agent any
            steps
            {
               
                sh '''ssh \'1972001@10.10.196.130\' docker run  --name buildmgr -v DesktopUIAutomation_vol:/src localhost:5000/buildmanager_desktopui_testimage:v1'''
               
            }}
        
        
        stage('Start mongodb')
        {   
            agent any
            steps
            {
               
                sh '''ssh \'1972001@10.10.196.130\' docker run --name mongo-de -d -v mongodbvol:/data/db -p 27017:27017 mongo'''
               
            }
        }
        stage('Executetest')
        {   
            agent any
            steps
            {
                sh '''ssh \'1972001@10.10.196.130\' docker run --name Testrunner2 --link mongo-de:mongo -v DesktopUIAutomation_vol:/src localhost:5000/test_runner_desktopui_testimage:v1'''
               
            }
        }
        stage("Cucumber Report"){
        steps{
            sh '''ssh -T -v \'1972001@10.10.196.130\' /home/1972001/PushReportToJenkins.sh'''
            
            cucumber failedFeaturesNumber: -1, failedScenariosNumber: -1, failedStepsNumber: -1, 
            fileIncludePattern: '**/*.json', jsonReportDirectory: '/var/jenkins_home/', 
            pendingStepsNumber: -1, skippedStepsNumber: -1, sortingMethod: 'ALPHABETICAL', undefinedStepsNumber: -1
           
}
}
        stage("Nexus upload"){
        steps{
            script{
                     sh '''ssh \'1972001@10.10.196.130\' /home/1972001/nexusscript.sh'''
                       
                 
            }}}


        
       stage('Clearing Active Containers')
        {   
            agent any
            steps
            {
                
               
              sh '''ssh \'1972001@10.10.196.130\' docker stop mongo-de'''
                sh '''ssh \'1972001@10.10.196.130\' docker rm mongo-de'''
            
               sh '''ssh \'1972001@10.10.196.130\' docker stop Testrunner2'''
                sh '''ssh \'1972001@10.10.196.130\' docker rm Testrunner2'''
                
               sh '''ssh \'1972001@10.10.196.130\' docker stop buildmgr'''
                sh '''ssh \'1972001@10.10.196.130\' docker rm buildmgr'''
            }
        }
    }}

