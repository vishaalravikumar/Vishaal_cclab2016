//
//  Particles.cpp
//  Fireworks in class
//
//  Created by Vishaal Ravikumar on 11/8/16.
//
//

#include "Particles.hpp"


void Particle::setup(){
    
    pos.x = ofGetWidth()/2;
    pos.y = 50;
    
    radius = 3.5;
    
    vel.x = ofRandom(-1,1);
    vel.y = ofRandom(0,2);
    
    color = ofColor(ofRandom(255), ofRandom(255), ofRandom(255));
    
    someNumber = ofRandom(1, 400);
    
}


void Particle::explosion(){
    
    pos = pos + vel;
    //pos -= vel;
    
    
}


void Particle::draw(){
    
    ofSetColor(color);
    ofEllipse(pos.x, pos.y, radius, radius);
    
}

void Particle::restart(){
    
    pos.x = ofGetWidth()/2;
    pos.y = 50;
    
    
}





