# continuousDeliveryDemo
Demo for http://southdakotacodecamp.net/sessions/101 about Continuous Delivery and the new Microsoft Build system in 2015

## Steps to get Selenium tests running
 1. Go to the test tab in the  VSO project
 1. create Windows 10 enterprise - in https://portal.azure.com, this is also possible through a PowerShell script. You'll want more than 1 to run tests in parallel.
 1. get the ip address of that VM (shutting down and starting gives you a different IP, will scripting this help manage this)
  * Port?
 1. RDP into the agent, instal Firefox and other browser that you want to run tests on.
  - Azure > VM > click the connect icon. Use the user you setup when creating the VM
  - Selenium has Firefox built in. [Other browser drivers can be downloaded](http://docs.seleniumhq.org/download/).
  
## Links

### Continuous Delivery
 - [Highly recommended book by Jez Humble and David Farley](http://www.continuousdelivery.com) 
 - [Links to videos and talks](http://continuousdelivery.com/talks/)
 - http://blogs.msdn.com/b/uk_faculty_connection/archive/2015/09/07/continuous-integration-and-testing-using-visual-studio-online.aspx
 - http://blogs.msdn.com/b/visualstudioalm/archive/2015/05/29/testing-in-continuous-integration-and-continuous-deployment-workflows.aspx
### Visual Studio Online/TFS Build
 - http://www.pluralsight.com/courses/tfs-build-2015-first-look
 - [TFS 2015 release notes](https://www.visualstudio.com/news/tfs2015-update1-vs)
  - [Support for Azure Resource Groups in Update 1](https://www.visualstudio.com/news/tfs2015-update1-vs#azurergp)
 - http://geekswithblogs.net/jakob/archive/2015/01/15/tfs-build-vnext-ndash-a-preview.aspx
 - https://msdn.microsoft.com/en-us/Library/vs/alm/Build/agents/windows
 - Setting Up Test Controllers and Test Agents to Manage Tests with Visual Studio -> https://msdn.microsoft.com/en-us/library/vstudio/hh546459(v=vs.140).aspx
 - Azure preview of DevTest labs
  - https://azure.microsoft.com/en-us/campaigns/devtest-lab/
  - https://azure.microsoft.com/en-us/documentation/scenarios/devtest/
 -  [host on GitHub build on VSO](http://ivision.com/blog/using-visual-studio-online-to-build-a-github-hosted-javascript-project-with-npm-bower-and-grunt-for-free/)
  - http://geekswithblogs.net/jakob/archive/2015/06/12/building-github-repositories-in-tfs-build-vnext.aspx
  
#### Dig Deeper
 - [Generate custom build numbers](http://geekswithblogs.net/jakob/archive/2015/10/15/generate-custom-build-numbers-in-tfs-build-vnext.aspx)
 - [Technical Debt Management: Announcing SonarQube integration with MSBuild and Team Build](http://blogs.msdn.com/b/visualstudioalm/archive/2015/04/28/technical-debt-management-announcing-sonarqube-integration-with-msbuild-and-team-build.aspx)
   - [in VSO build as of Sept 1, 2015](http://www.sonarqube.org/msbuild-sonarqube-runner-now-available-on-visual-studio-online/)
 - [Test Pyramid for Automation Testing](http://martinfowler.com/bliki/TestPyramid.html)
   - [not the ice cream cone](http://watirmelon.com/2012/01/31/introducing-the-software-testing-ice-cream-cone/)
 
### Specifications By Example
 - [Suggested Specifications By Example book](http://specificationbyexample.com/)
 - http://cqrsjourney.github.io/blog/2012/05/14/Specing-Out-End-To-End-Scenarios/
 - http://stackoverflow.com/questions/3443302/specflow-bdd-examples
  
 ### Other build technology offerings:
  - http://www.pluralsight.com/courses/continuous-integration-psake-teamcity-getting-started