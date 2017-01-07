precision mediump float;
varying vec2 v_uv;
uniform sampler2D u_texture_0;
uniform sampler2D u_texture_1;
uniform sampler2D u_texture_2;
uniform float u_Time;
uniform float u_ampFactor;  

void main()
{
	vec2 disp=texture2D(u_texture_2,vec2(v_uv.x,mod((v_uv.y+u_Time),1.0))).rg;
	vec2 offset=(2.0*disp-1.0)*u_ampFactor;

	vec2 new_uv=v_uv+offset;
	vec4 AlphaValue=texture2D(u_texture_1,v_uv);
	gl_FragColor = texture2D(u_texture_0, new_uv)*(1.0,1.0,1.0,AlphaValue.r); 
}
