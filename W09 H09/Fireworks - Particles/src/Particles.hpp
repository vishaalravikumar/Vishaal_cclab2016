//
//  Particles.hpp
//  Fireworks in class
//
//  Created by Vishaal Ravikumar on 11/8/16.
//
//

#pragma once

#include "ofMain.h"

class Particle{
    
public:
    
    void draw();
    void setup();
    void explosion();
    
    void restart();
    
    ofPoint pos;
    ofPoint vel;
    ofColor color;
    
    float radius;
    int someNumber;
    
    
    
};