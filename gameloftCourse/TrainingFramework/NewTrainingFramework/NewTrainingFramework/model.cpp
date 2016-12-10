#include "stdafx.h"
#include "model.h"
#include "Vertex.h"

model::model()
{
}


model::~model()
{
}

void model::loadVertices(const char * fileName)
{
	FILE * file = fopen(fileName, "r");
	if (file == NULL) {
		printf("Impossible to open the file !\n");    
		return;
	}
		/*char lineHeader[256];
		int res = fscanf(file, "%s", lineHeader);
		if (res == EOF)
			break; // EOF = Конец файла. Заканчиваем цикл чтения*/
		fscanf_s(file, "NrVertices: %d", &nrVertices);
		vertices = new Vertex[nrVertices];
		for (int i = 0; i < nrVertices; i++) {
			fscanf_s(file, " %*d. pos:[%f, %f, %f]; norm:[%*f, %*f, %*f]; binorm:[%*f, %*f, %*f]; tgt:[%*f, %*f, %*f]; uv:[%*f, %*f];", &vertices[i].pos.x, &vertices[i].pos.y, &vertices[i].pos.z/*, &vertices[i].uv.x, &vertices[i].uv.y*/);
			printf(" %d. pos:[%f, %f, %f]; uv:[%f, %f];\n", i, vertices[i].pos.x, vertices[i].pos.y, vertices[i].pos.z/*, vertices[i].uv.x, vertices[i].uv.y*/);
		}
		fscanf_s(file,"");//дочитать строку до конца
		fscanf_s(file, " NrIndices: %d", &nrIndices);
		indices = new unsigned int[nrIndices];
		for (int i = 0; i < nrIndices; i+=3) {
			fscanf_s(file,"   %*d.    %d,    %d,    %d", &indices[i], &indices[i+1], &indices[i+2]);
			printf("%d %d %d\n", indices[i], indices[i + 1], indices[i + 2]);
		}
		glGenBuffers(1, &m_hIndexBuffer);
		glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, m_hIndexBuffer);
		glBufferData(GL_ELEMENT_ARRAY_BUFFER, sizeof(unsigned int) * nrIndices, indices, GL_STATIC_DRAW);
		glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, m_hIndexBuffer);
		glGenBuffers(1, &m_hVertexBuffer); //buffer object name generation
		glBindBuffer(GL_ARRAY_BUFFER, m_hVertexBuffer); //buffer object binding
		glBufferData(GL_ARRAY_BUFFER, sizeof(Vertex)*nrVertices, vertices, GL_STATIC_DRAW); //creation and initializion of buffer onject storage
		glBindBuffer(GL_ARRAY_BUFFER, m_hVertexBuffer);
		delete[]vertices;
		delete[]indices;

}