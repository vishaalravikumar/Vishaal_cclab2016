#include "ofApp.h"

//--------------------------------------------------------------
void ofApp::setup(){
    
    num = 800;
    
    for(int i=0; i< num; i++){
        //initialise the array
        
        Particle temp;
        temp.setup();
        particles.push_back(temp);
        
        
        
    }

}

//--------------------------------------------------------------
void ofApp::update(){

}

//--------------------------------------------------------------
void ofApp::draw(){
    
    ofBackground(0, 0, 0);
   // for(int i=0; i< particles.size(); i++){
    
    for(int i=0; i< num; i++){
        
        particles[i].explosion();
        particles[i].draw();
        
        cout<<ofGetFrameNum()<<endl;
        
        if(ofGetFrameNum() % particles[i].someNumber == 0){
            particles[i].restart();
            
        }
//        particles[i].restart();
        
    }

}

//--------------------------------------------------------------
void ofApp::keyPressed(int key){

}

//--------------------------------------------------------------
void ofApp::keyReleased(int key){

}

//--------------------------------------------------------------
void ofApp::mouseMoved(int x, int y ){

}

//--------------------------------------------------------------
void ofApp::mouseDragged(int x, int y, int button){

}

//--------------------------------------------------------------
void ofApp::mousePressed(int x, int y, int button){

}

//--------------------------------------------------------------
void ofApp::mouseReleased(int x, int y, int button){

}

//--------------------------------------------------------------
void ofApp::mouseEntered(int x, int y){

}

//--------------------------------------------------------------
void ofApp::mouseExited(int x, int y){

}

//--------------------------------------------------------------
void ofApp::windowResized(int w, int h){

}

//--------------------------------------------------------------
void ofApp::gotMessage(ofMessage msg){

}

//--------------------------------------------------------------
void ofApp::dragEvent(ofDragInfo dragInfo){ 

}
