// NewTrainingFramework.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "../Utilities/utilities.h" 
#include "Vertex.h"
#include "Shaders.h"
#include "Globals.h"
#include <conio.h>
#include <vector>
#include "model.h"


GLuint vboId;
Shaders myShaders;
Matrix m, m2;
float m_time;
model woman;
int Init ( ESContext *esContext )
{
	glClearColor(0.0f, 0.0f, 0.0f, 0.0f);
	glEnable(GL_DEPTH_TEST);
	m.SetIdentity();

	woman.loadModel("../Resources/Models/Woman1.nfg");
	woman.loadTexture("../Resources/Textures/Woman1.tga");

	//creation of shaders and program 
	return myShaders.Init("../Resources/Shaders/TriangleShaderVS.vs", "../Resources/Shaders/TriangleShaderFS.fs");

}

void Draw(ESContext *esContext)
{
	glClear(GL_COLOR_BUFFER_BIT);
	glUseProgram(myShaders.program);
	glBindBuffer(GL_ARRAY_BUFFER, woman.m_hVertexBuffer); //binded model's vertices
	glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, woman.m_hIndexBuffer); //binded indices

	unsigned short textureUnit = 0;// make active a texture unit 
	glActiveTexture(GL_TEXTURE0 + textureUnit);// bind the texture to the currently active texture unit 
	glBindTexture(GL_TEXTURE_2D, woman.textureHandle);// set the uniform sampler 
	glUniform1i(myShaders.uniformLocation, textureUnit);

	GLfloat* ptr = (GLfloat *)0;
	if (myShaders.positionAttribute != -1)
	{
		glEnableVertexAttribArray(myShaders.positionAttribute);
		glVertexAttribPointer(myShaders.positionAttribute, 3, GL_FLOAT, GL_FALSE, sizeof(Vertex), ptr);
	}
	if (myShaders.uvAttribute != -1)
	{
		glEnableVertexAttribArray(myShaders.uvAttribute);
		glVertexAttribPointer(myShaders.uvAttribute, 2, GL_FLOAT, GL_FALSE, sizeof(Vertex), ptr+3);
	}
	if (myShaders.matrixTransform != -1) {
		glUniformMatrix4fv(myShaders.matrixTransform, 1, false, (GLfloat *)&m);
	}

	glDrawElements(GL_TRIANGLES, woman.nrIndices, GL_UNSIGNED_INT, (void*)0);


	glBindBuffer(GL_ARRAY_BUFFER, 0);
	glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, 0);

	eglSwapBuffers ( esContext->eglDisplay, esContext->eglSurface );
}

void Update ( ESContext *esContext, float deltaTime )
{
	m_time += deltaTime;
	m.SetRotationAngleAxis(m_time, 0.0f, 0.1f, 0.0f);
	m2.SetTranslation(0.0f, -1.0f, 0.0f);
	m=m*m2;
}

void Key ( ESContext *esContext, unsigned char key, bool bIsPressed)
{

}

void CleanUp()
{
	glDeleteBuffers(1, &vboId);
}

int _tmain(int argc, _TCHAR* argv[])
{
	ESContext esContext;

    esInitContext ( &esContext );

	esCreateWindow ( &esContext, "Hello Triangle", Globals::screenWidth, Globals::screenHeight, ES_WINDOW_RGB | ES_WINDOW_DEPTH);

	if ( Init ( &esContext ) != 0 )
		return 0;

	esRegisterDrawFunc ( &esContext, Draw );
	esRegisterUpdateFunc ( &esContext, Update );
	esRegisterKeyFunc ( &esContext, Key);

	esMainLoop ( &esContext );

	//releasing OpenGL resources
	CleanUp();

	//identifying memory leaks
	MemoryDump();
	printf("Press any key...\n");
	_getch();

	return 0;
}

