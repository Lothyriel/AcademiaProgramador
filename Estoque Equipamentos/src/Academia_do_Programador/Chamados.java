package Academia_do_Programador;

import java.util.Date;

/**
 * @author JX
 */
public class Chamados {
    private String chamado;
    private String desc;
    private Equipamentos equipamento;
    private Date data_abertura;

    public Chamados(String chamado, String desc, Equipamentos equipamento, Date data_abertura) {
        this.chamado = chamado;
        this.desc = desc;
        this.equipamento = equipamento;
        this.data_abertura = data_abertura;
    }

    public String getChamado() {
        return chamado;
    }

    public void setChamado(String chamado) {
        this.chamado = chamado;
    }

    public String getDesc() {
        return desc;
    }

    public void setDesc(String desc) {
        this.desc = desc;
    }

    public Equipamentos getEquipamento() {
        return equipamento;
    }

    public void setEquipamento(Equipamentos equipamento) {
        this.equipamento = equipamento;
    }

    public Date getData_abertura() {
        return data_abertura;
    }

    public void setData_abertura(Date data_abertura) {
        this.data_abertura = data_abertura;
    }
}
