
pipeline {
    agent any
    
    stages {
        pipeline{
    stage('git watch') {
            steps {
       git credentialsId: '4f90e1bb-2653-447a-a345-4b28df60b37c', url: 'https://github.com/sangeetha-partha/AppSourcecode.git'
            }} 
       stage('copy test automation suite from git') {
            steps {
                sh '''ssh -T -v \'1972001@10.10.196.130\' /home/1972001/copy.sh'''
                
            }
        }
       
        /*stage('start winappserver') {
            steps {
                sh '''ssh -T -v \'1972001@10.10.196.130\' /home/1972001/winappserver.sh'''
                
            }
        }*/
        
        
        
        stage('copy app sourcecode from git') {
            steps {
                sh '''ssh -T -v \'1972001@10.10.196.130\' /home/1972001/Extractsourcecode.sh'''
                
            }
        }
        stage('remove debug and Release') {
            steps {
                sh '''ssh -T -v \'1972001@10.10.196.130\' /home/1972001/removesourcecode.sh'''
                
            }
        }
        
        stage('build App source code') {
            steps {
                sh '''ssh -T -v \'1972001@10.10.196.130\' /home/1972001/sourcecodebuild.sh'''
                
            }
        }
        stage('BuildManager')
        {   
            agent any
            steps
            {
               /* sh '''ssh \'1972001@10.10.196.130\' docker pull localhost:5000/buildmanager_desktopui_testimage:v1'''*/
                sh '''ssh \'1972001@10.10.196.130\' docker run  --name buildmgr -v DesktopUIAutomation_vol:/src localhost:5000/buildmanager_desktopui_testimage:v1'''
               
            }
        }
        
        stage('Start mongodb')
        {   
            agent any
            steps
            {
               
                sh '''ssh \'1972001@10.10.196.130\' docker run --name mongo-de -d -v mongodbvol:/data/db -p 27017:27017 mongo'''
               
            }
        }
        stage('executetest')
        {   
            agent any
            steps
            {
                sh '''ssh \'1972001@10.10.196.130\' docker run --name Testrunner2 --link mongo-de:mongo -v DesktopUIAutomation_vol:/src localhost:5000/test_runner_desktopui_testimage:v1'''
               
            }
        }
        stage("Nexus upload"){
        steps{
            script{
                     sh '''ssh \'1972001@10.10.196.130\' /home/1972001/nexusscript.sh'''
                       
                 
            }
}}
        
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
    }
}
    
    
    

