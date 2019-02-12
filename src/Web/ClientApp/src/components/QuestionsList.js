import React, { Component } from 'react';

export class QuestionsList extends Component {
    displayName = QuestionsList.name

    constructor(props) {
        super(props);
        this.state = { questions: [], loading: true };

        fetch('api/questions?sort=lastActivityDate&tagged=asp.net&inTitle&page=1&pageSize=5')
            .then(response => response.json())
            .then(data => {
                this.setState({ questions: data.items, loading: false });
            });
    }

    static renderQuestionsTable(questions) {
        return (
            <div className="container-fluid">
                {questions.map(q =>
                    <div key={q.id.toString()} className="panel panel-default">
                        <div className="panel-body">
                            <div className="row">
                                <div className="col-xs-1">
                                    <div className="panel panel-success">
                                        <div className="panel-body">
                                            <div className="center-block">
                                                <h3>{q.answerCount}</h3>
                                                <small>Answers</small>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div className="col-md-6">
                                    <h3>{q.title}</h3>
                                    {q.tags.map(t =>
                                        <span className="label label-success">{t}</span> 
                                        
                                    )}
                                </div>
                            </div>
                        </div>
                    </div>
                )}
            </div>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : QuestionsList.renderQuestionsTable(this.state.questions);

        return (
            <div>
                <h1>All Questions</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {contents}
            </div>
        );
    }
}
